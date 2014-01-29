using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Fahrenheit fahrenheit = float.Parse(textBox1.Text);
            textBox2.Text = fahrenheit.Celsius().ToString();
            textBox3.Text = fahrenheit.Kelvin().ToString();

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            Celsius celsius = float.Parse(textBox2.Text);
            textBox1.Text = celsius.Fahrenheit().ToString();
            textBox3.Text = celsius.Kelvin().ToString();

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            Kelvin kelvin = float.Parse(textBox3.Text);
            textBox1.Text = kelvin.Fahrenheit().ToString();
            textBox2.Text = kelvin.Celsius().ToString();
        }
    }
}
