using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epifan_CS_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gridSize = 10;
            dataGridView1.RowCount = gridSize; //Указываем количество строк
            dataGridView1.ColumnCount = gridSize; //Указываем количество столбцов
            dataGridView2.RowCount = gridSize;
            dataGridView2.ColumnCount = gridSize;

            int[,] a = new int[gridSize, gridSize]; //Инициализируем массив

            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (int y = 0; y < gridSize; y++)
                for (int x = 0; x < gridSize; x++)
                    a[y, x] = rand.Next(-30, 30);
            //Выводим матрицу в dataGridView1
            for (int y = 0; y < gridSize; y++)
                for (int x = 0; x < gridSize; x++)
                    dataGridView1.Rows[y].Cells[x].Value = Convert.ToString(a[y, x]);

            //производим поиск максимального элемента
            int maxInGrid = int.MinValue;
            int maxY = 0;
            int maxX = 0;
            for (int y = 0; y < gridSize; y++)
                for (int x = 0; x < gridSize; x++)
                    if (a[y,x] > maxInGrid)
                    {
                        maxInGrid = a[y, x];
                        maxY = y;
                        maxX = x;
                    }

            // заменяем столбец и строку на нули
            for (int y = 0; y < gridSize; y++)
                a[y, maxX] = 0;
            for (int x = 0; x < gridSize; x++)
                a[maxY, x] = 0;

            // выводим полученную матрицу
            for (int y = 0; y < gridSize; y++)
                for (int x = 0; x < gridSize; x++)
                    dataGridView2.Rows[y].Cells[x].Value = Convert.ToString(a[y, x]);

            textBox1.Text = Convert.ToString(maxInGrid);
        }
    }
}
