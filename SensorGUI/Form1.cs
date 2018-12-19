using Newtonsoft.Json;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SensorGUI
{
    public partial class Form1 : Form
    {
        private ValueHolder value_holder = new ValueHolder();
        private Website web_connect = new Website();
        private string data = String.Empty;
        private string[] adc_values = new string[3];
        private const string WEBSITE_URL = "http://sensordata.tk:90/api/Sensor";
        private const char EOT_CHAR = '|';


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cb_connect.Items.Add(s);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            uart.Close();
            uart.Dispose();
        }

        private void uart_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Thread.Sleep(100);
            //data = uart.ReadExisting();

            //Invoke(new EventHandler(uart_DataParser));
            //Trial code
            data = data + uart.ReadExisting();
            if (data.Contains(EOT_CHAR.ToString()))
                Invoke(new EventHandler(uart_DataParser));
        }

        private void uart_DataParser(object sender, EventArgs e)
        {
            //Used to get rid of rogue ending characters
            data = data.Replace("\0", "");
            data = data.TrimEnd('|');
            //--Parse data string and put in respective "database"--//
            //Split received string into 3 substrings each containing 1 adc value
            adc_values = data.Split(',');
            //After the first adc value there is a '\0' character which makes the
            //second string always null, Substring is used to avoid that
            //adc_values[1] = adc_values[1].Replace("\0", "");//Substring(1);
            //Populate each of the "databases" with most recent value at top
            tb_database1.Text = adc_values[0] + "\r\n" + tb_database1.Text;
            tb_database2.Text = adc_values[1] + "\r\n" + tb_database2.Text;
            tb_database3.Text = adc_values[2] + "\r\n" + tb_database3.Text;

            data = String.Empty;

            //--Calculate running average for each "database"--//
            //row variable to hold all rows in a single "database"
            string[] rows = new string[value_holder.Count];
            value_holder.Count++;

            //Calculate running average for first "database"
            rows = value_holder.ParseTextbox(tb_database1.Text);
            value_holder.CalculateTotal(rows);
            tb_average1.Text = value_holder.GetAverage().ToString();

            //Calculate running average for second "database"
            rows = value_holder.ParseTextbox(tb_database2.Text);
            value_holder.CalculateTotal(rows);
            tb_average2.Text = value_holder.GetAverage().ToString();

            //Calculate running average for third "database"
            rows = value_holder.ParseTextbox(tb_database3.Text);
            value_holder.CalculateTotal(rows);
            tb_average3.Text = value_holder.GetAverage().ToString();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(!uart.IsOpen)
            {
                if(cb_connect.Text != "")
                {
                    tb_connect.Text = "Connecting...";
                    Application.DoEvents(); //Allows windows to put text on screen
                    uart.PortName = cb_connect.Text;
                    uart.Open();
                }
            }

            if(uart.IsOpen)
            {
                tb_connect.Text = "Connected";
            }
            else
            {
                tb_connect.Text = "Unable to Connect";
            }
        }

        private void btn_website_Click(object sender, EventArgs e)
        {
            try
            {
                int temp;
                DataReadings dataReadings = new DataReadings();

                if (!Int32.TryParse(adc_values[0], out temp))
                    throw new Exception("ADC 0 data invalid");
                else
                    dataReadings.Moisture = temp;

                if (!Int32.TryParse(adc_values[1], out temp))
                    throw new Exception("ADC 1 data invalid");
                else
                    dataReadings.Luminosity = temp;

                if (!Int32.TryParse(adc_values[2], out temp))
                    throw new Exception("ADC 2 data invalid");
                else
                    dataReadings.Temperature = temp;
                
                tb_website_response.Text = web_connect.SendWebsiteData(WEBSITE_URL, JsonConvert.SerializeObject(dataReadings));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex.Message, "Failed to send to website");
            }   
        }
    }
}
