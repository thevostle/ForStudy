using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epifan_CS_6
{
    public partial class Form1 : Form
    {
        double[] Mas = new double[25];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 25; i++)
            {
                Mas[i] = rand.NextDouble() * rand.Next(-10,10);
                textBox1.Text += Convert.ToString(Mas[i]) + Environment.NewLine;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count_range = 0;
            int count_negative = 0;

            for (int i = 0; i < 25; i++)
            {
                if (Mas[i] < 0)
                    count_negative++;
                if (1 <= Mas[i] && Mas[i] <= 2)
                    count_range++;
            }

            textBox2.Text += "Отрицательных чисел: " + Convert.ToString(count_negative) + Environment.NewLine + "Чисел от 1 до 2: " + Convert.ToString(count_range);
        }
    }
}
