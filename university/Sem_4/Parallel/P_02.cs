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

        // однопоточная сортировка вставками
        static ArrayList Sort(ArrayList arraySort)
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

        // многопоточная сортировка вставками
        static ArrayList SortP(ArrayList arraySort)
        {
            // разделяем один список на 2 части (числа меньше и больше якорного элемента)
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

            // сортируем их последовательным методом одновременно на нескольких потоках
            Task<ArrayList>[] taskArray = { Task<ArrayList>.Factory.StartNew(() => Sort(arr1)),
                                            Task<ArrayList>.Factory.StartNew(() => Sort(arr2))};

            // объединяем обратно в один список
            ArrayList result = taskArray[0].Result;
            for (int i = 0; i < taskArray[1].Result.Count; i++)
                result.Add(taskArray[1].Result[i]);

            return result;
        }

        // array - выводимый список
        // range1/range2 - кол-во выводимых чисел из начала и конца списка
        // name - название списка
        static void PrintArray(ArrayList array, int range1, int range2, string name)
        {
            Console.Write("{0}: ", name);
            for (int i = 0; i < range1 - 1; i++)
                Console.Write("{0}, ", array[i]);
            Console.Write("{0}", array[range1 - 1]);
            Console.Write(" ... ");
            for (int i = array.Count - range2; i < array.Count - 1; i++)
                Console.Write("{0}, ", array[i]);
            Console.Write("{0}\n", array[array.Count - 1]);
        }

        static void Main(string[] args)
        {
            // создаем набор данных
            Random rnd = new Random();
            double[] originArr = new double[arrLen];
            for (int i = 0; i < arrLen; i++)
                originArr[i] = rnd.Next(0, maxNum);
       
            // сохраняем копию массива для сортировки    
            ArrayList arr_copy = new ArrayList();
            for (int i = 0; i < arrLen; i++)
                arr_copy.Add(originArr[i]);

            // запускаем последовательную реализацию
            sw.Restart();
            ArrayList resArr1 = Sort(arr_copy);
            long TS = sw.ElapsedMilliseconds;
            Console.WriteLine("Отсортирован последовательно за {0} мс", TS);

            // запускаем параллельную реализацию
            sw.Restart();
            ArrayList resArr2 = SortP(arr_copy);
            TS = sw.ElapsedMilliseconds;
            Console.WriteLine("Отсортирован параллельно за {0} мс", TS);

            // вывод
            Console.WriteLine();
            PrintArray(arr_copy, 5, 5, "Оригинальный массив");
            PrintArray(resArr1, 5, 5, "Отсортированный последовательно");
            PrintArray(resArr2, 5, 5, "Отсортированный параллельно");
        }
    }
}
