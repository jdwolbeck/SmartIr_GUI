using System;
using System.Windows.Forms;

namespace SensorGUI
{
    public partial class Form1 : Form
    {
        ValueHolder value_holder = new ValueHolder();
        Website web_connect = new Website();

        public Form1()
        {
            InitializeComponent();
            foreach(string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cb_connect.Items.Add(s);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(!uart.IsOpen)
            {
                if(cb_connect.Text != null)
                {
                    uart.Open();
                }
            }

            if(uart.IsOpen)
            {
                tb_connect.Text = "Serial Port open";
            }
            else
            {
                tb_connect.Text = "Serial Port NOT open";
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            tb_database.Text = (random.Next()%10).ToString() + "\r\n" + tb_database.Text;

            value_holder.IncrementCount();

            string[] rows = new string[value_holder.count];
            rows = value_holder.ParseTextbox(tb_database.Text);

            value_holder.CalculateTotal(rows);
            
            tb_average.Text = value_holder.GetAverage().ToString();
        }

        private void btn_website_Click(object sender, EventArgs e)
        {
            tb_website_response.Text = web_connect.SendWebsiteData("http://sensordata.tk:90/api/Sensor", value_holder.average.ToString());
        }
    }
}
