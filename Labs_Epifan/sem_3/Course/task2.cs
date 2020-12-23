using System;

namespace Epifan_Course_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // размер матрицы
            int m = 3; 
            int n = 5;

            double[,] a = { { 0.5, 1, 2, 4.6, 3 }, { 7, 4, 5, 4.3, 7}, { 6, 6, 7, 3.2, 4} }; // сама матрица

            double[] mins = new double[m]; // массив для всех наименьших в строках чисел (у нас m строк, значит m чисел)

            double minInGrid = float.MaxValue; // делаем число максимально большим, чтобы числа в матрицы точно были меньше
            
            for (int y = 0; y < m; y++) // просматриваем каждый ряд
            {
                double minX = 0; // наименьшее число в строке
                minInGrid = a[y, 0]; // 
                for (int x = 0; x < n; x++)
                {
                    if (a[y, x] < minInGrid)
                    {
                        minInGrid = a[y, x];
                        minX = x;
                    }
                }
                mins[y] = minX;
            }

            foreach (double i in mins)
                Console.WriteLine(i);
        }
    }
}
