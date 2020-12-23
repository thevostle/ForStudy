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
                minInGrid = a[y, 0]; // наименьшее число в строке
                
                for (int x = 0; x < n; x++) // просматриваем каждый столбец
                    if (a[y, x] < minInGrid) // если число в матрице меньше найденного наименьшего...
                        minInGrid = a[y, x]; // обновляем найденное наименьшее
                
                mins[y] = minInGrid; // добавляем найденное наименьшее в массив mins
            }

            foreach (double i in mins) // берем каждое число из mins
                Console.WriteLine(i); // и выводим его
        }
    }
}
