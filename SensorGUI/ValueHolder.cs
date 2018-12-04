using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGUI
{
    class ValueHolder
    {
        public ValueHolder() // Constructor
        {
            count = 0;
            average = 0;
            total = 0;
        }

        public void IncrementCount()
        {
            if (count == 28)
                count = 28;
            else
                count++;
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
            for (int i = 0; i < count; i++)
            {
                total += Int32.Parse(s[i]);
            }
        }

        public int count;
        public float average;
        public float total;
    }
}
