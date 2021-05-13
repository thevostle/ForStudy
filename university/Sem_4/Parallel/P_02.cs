// С# с использованием библиотеки Task Parallel Library
// сортирует по возрастанию одномерный массив чисел типа double методом вставок 

// параллельная реализация не работает, остальное норм

using System;
using System.Threading;
using System.Threading.Tasks;

namespace P_02_CSharp_TPL
{
    class Program
    {
        const int arrLen = 50000;

        // для измерения продолжительности
        static System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        static double[] Sort(double[] arraySort)
        {
            double[] result = new double[arraySort.Length];
            for (int i = 0; i < arraySort.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > arraySort[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = arraySort[i];
            }
            return result;
        }

        static void SortP_Realization(double[] arraySort, ParallelLoopState pls)
        {
            double[] result = new double[arraySort.Length];
            for (int i = 0; i < arrLen; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > arraySort[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = arraySort[i];
            }
        }

        static double[] SortP(double[] arraySort)
        {
            double[] result = new double[arraySort.Length];
            //ParallelLoopResult res = Parallel.For(0, arrLen, SortP_Realization);
            return result;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] array = new double[arrLen];
            for (int i = 0; i < arrLen; i++) 
                array[i] = rnd.Next(0, 1000000);

            double[] arrayP = new double[arrLen]; // сохраняем массив для параллельной сортировки
            array.CopyTo(arrayP, 0);

            // запускаем последовательную реализацию
            sw.Restart();
            double[] sorted = Sort(array);
            long TS = sw.ElapsedMilliseconds;
            Console.WriteLine("\nTime: {0} ms", TS);

            // запускаем последовательную реализацию
            sw.Restart();
            double[] sortedP = SortP(array);
            TS = sw.ElapsedMilliseconds;
            Console.WriteLine("\nTime: {0} ms", TS);

            // вывод отсортированного массива
            //for (int i = 0; i < arrLen; i++)
            //    Console.WriteLine(Convert.ToString(sorted[i]));
        }
    }
}
