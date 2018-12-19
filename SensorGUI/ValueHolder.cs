using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorGUI
{
    class ValueHolder
    {
        private int count;
        private float average;
        private float total;

        public ValueHolder()
        {
            count = 0;
            average = 0;
            total = 0;
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public float GetAverage()
        {
            average = total / count;
            total = 0;
            return average;
        }

        public string[] ParseTextbox(string s)
        {
            TextReader read = new System.IO.StringReader(s);
            string[] row_text = new string[count];
            for (int i = 0; i < count; i++)
            {
                row_text[i] = read.ReadLine();
            }
            return row_text;
        }

        public void CalculateTotal(string[] s)
        {
            int temp = 0;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    if (Int32.TryParse(s[i], out temp))
                        total += temp;
                    else
                        throw new Exception("Invalid string.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Execption: " + ex, "ValueHolder Class error");
                }
                
            }
        }
    }
}
