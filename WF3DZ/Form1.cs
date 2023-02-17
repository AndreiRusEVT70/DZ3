using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF3DZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double result = 0;

            if(radioButton1.Checked)
            {
                result = 5 * x + 10 / y;
                textBox3.Text = result.ToString();
            }

            else if(radioButton2.Checked)
            {
                result = 3 * Math.Pow(x, 2) + y + 3;
                textBox3.Text = result.ToString();
            }

            else if (radioButton3.Checked)
            {
                result = (x + 10 * y) / 3;
                textBox3.Text = result.ToString();
            }
        }
    }
}
