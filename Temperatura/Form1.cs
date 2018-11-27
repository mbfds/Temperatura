using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            float c, f;

            f = float.Parse(txtbTemperatura.Text);
            c = (f - 32) / (float)1.8;

            txtbResultado.Text = Convert.ToString(c);

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            float c, f;

            f = float.Parse(txtbTemperatura.Text);
            c = (f + 32) * (float)1.8;

            txtbResultado.Text = Convert.ToString(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float c,f;
            f = float.Parse(txtbTemperatura.Text);

            c = (f - 32) / (float)1.8;

            txtbResultado.Text = Convert.ToString(c);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c, f;
            f = double.Parse(txtbTemperatura.Text);

            c = (f + 459.67) / (double)1.8; 

            txtbResultado.Text = Convert.ToString(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double c, f;
            f = double.Parse(txtbTemperatura.Text);

            c = f - 273.15;


            txtbResultado.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float c, f;
            f = float.Parse(txtbTemperatura.Text);

            c = (f *(float) 1.8 + 32) ;

            txtbResultado.Text = Convert.ToString(c);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double c, f;
            f = double.Parse(txtbTemperatura.Text);

            c = f - 273.15;
			txtbResultado.Text = Convert.ToString(c);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			double c, f;
			f = double.Parse(txtbTemperatura.Text);

			c = ((f - 273.15) * (double)1.8)+32;

			txtbResultado.Text = Convert.ToString(c);
		}
	}
}
