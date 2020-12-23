using System;

namespace Epifan_Course_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[64]; // массив чисел из которых будем делать матрицу
            double[,] a = new double[8,8]; // сама матрица

            Random rng = new Random(); // готовим модуль рандомной генерации
            for (int i = 0; i < 64; i++)
            {
                arr[i] = rng.NextDouble(); // забиваем массив дробными числами
                // arr[i] = i; ДЕБАГ: тут будут числа по порядку
            }
            
            for (int i = 0; i < 64; i++) 
                Console.WriteLine(arr[i]); // выводим исходные данные
            Console.WriteLine(); // разделяем код для красоты
            
            for (int y = 0; y < 8; y++) // просматриваем каждую строку
            {
                if (y % 2 == 1) // если она нечетная...
                    for (int x = 0; x < 8; x++)
                        a[y, x] = arr[y * 8 + x]; // заполняем по порядку
                else // если нет...
                    for (int x = 8; x > 0; x--)
                        a[y, x-1] = arr[y * 8 + 8 - x]; // ... в обратном порядке
            }

            // выводим получившуюся матрицу
            for (int y = 0; y < 8; y++) 
            { 
                for (int x = 0; x < 8; x++) 
                { 
                    Console.Write(a[y,x]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
