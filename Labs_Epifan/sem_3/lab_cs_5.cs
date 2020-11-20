using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epifan_CS_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int count_0 = 0;
            int count_1 = 0;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == '0')
                    count_0++;
                else if (str[i] == '1')
                    count_1++;
                i++;
            }
            label1.Text = "Количество нулей = " + count_0.ToString() +  "\nКоличество едениц = " + count_1.ToString();
        }
    }
}
