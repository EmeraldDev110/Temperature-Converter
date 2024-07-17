using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox_InputTemperature.Text);
            double result = 0;

            if (radioButton_Fahrenheit.Checked == true)
                result = (input - 32) / 1.8;

            if (radioButton_Celsius.Checked == true)
                result = (input * 1.8) + 32;

            textBox_Result.Text = result.ToString();
        }
    }
}
