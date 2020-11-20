using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epifan_CS_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Solve(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)));
        }

        static double Solve(double x, double y, double z)
        {
            return (2 * Math.Cos(x - Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
        }
    }
}
