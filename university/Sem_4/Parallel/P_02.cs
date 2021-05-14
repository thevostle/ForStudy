// С# с использованием библиотеки Task Parallel Library
// сортирует по возрастанию одномерный массив чисел типа double методом вставок 

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace P_02_CSharp_TPL
{
    class Program
    {
        const int arrLen = 50000;
        const int maxNum = 10000;

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

        static ArrayList SortP_Realization(ArrayList arraySort)
        {
            double[] result = new double[arraySort.Count];
            for (int i = 0; i < arraySort.Count; i++)
            {
                int j = i;
                while (j > 0 && Convert.ToDouble(result[j-1]) > Convert.ToDouble(arraySort[i]))
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = Convert.ToDouble(arraySort[i]);
            }
            ArrayList resultArr = new ArrayList();
            for (int i = 0; i < arraySort.Count; i++)
                resultArr.Add(result[i]);
            return resultArr;
        }

        static ArrayList SortP(ArrayList arraySort)
        {
            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            for (int i = 0; i < arraySort.Count; i++)
            {
                double num = Convert.ToDouble(arraySort[i]);
                if (num < maxNum / 2)
                    arr1.Add(num);
                else
                    arr2.Add(num);
            }

            Task<ArrayList>[] taskArray = { Task<ArrayList>.Factory.StartNew(() => SortP_Realization(arr1)),
                                            Task<ArrayList>.Factory.StartNew(() => SortP_Realization(arr2))};

            ArrayList result = taskArray[0].Result;
            for (int i = 0; i < taskArray[1].Result.Count; i++)
                result.Add(taskArray[1].Result[i]);
            return result;
        }

        static void Main(string[] args)
        {
            // создаем набор данных
            Random rnd = new Random();
            double[] array = new double[arrLen];
            for (int i = 0; i < arrLen; i++) 
                array[i] = rnd.Next(0, maxNum);
            
            // сохраняем массив для параллельной сортировки
            double[] arrayP = new double[arrLen]; 
            array.CopyTo(arrayP, 0);
            ArrayList arr = new ArrayList();
            for (int i = 0; i < arrLen; i++)
                arr.Add(arrayP[i]);

            // запускаем последовательную реализацию
            sw.Restart();
            double[] sorted = Sort(array);
            long TS = sw.ElapsedMilliseconds;
            Console.WriteLine("\nTime: {0} ms", TS);

            // запускаем параллельную реализацию
            sw.Restart();
            ArrayList resArr = SortP(arr);
            TS = sw.ElapsedMilliseconds;
            Console.WriteLine("\nTime: {0} ms", TS);

            // вывод отсортированного массива
            //for (int i = 0; i < arrLen; i++)
            //    Console.WriteLine("{0}", Convert.ToString(sorted[i]));
            //for (int i = 0; i < arrLen; i++)
            //    Console.WriteLine(resArr[i]);
        }
    }
}
