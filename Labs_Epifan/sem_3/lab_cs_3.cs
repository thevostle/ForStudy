using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epifan_CS_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            int n = 0;
            if (radioButton2.Checked) n = 1;
            else if (radioButton3.Checked) n = 2;

            double u;
            double f = 0;
            switch (n)
            {
                case 0:
                    f = Math.Sinh(x);
                    break;
                case 1:
                    f = Math.Pow(x, 2);
                    break;
                case 2:
                    f = Math.Exp(x);
                    break;
            }

            if (x * y > 0) u = Math.Pow(f + y, 2) - Math.Sqrt(f * y);
            else if (x * y < 0) u = Math.Pow(f + y, 2) * Math.Sqrt(Math.Abs(f * y));
            else u = Math.Pow(f + y, 2) + 1;
            textBox3.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
        }
    }
}
