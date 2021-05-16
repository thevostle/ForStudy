// находит три максимальных элемента в одномерном массиве чисел типа double;

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace P_02_Gleb
{
    class Program
    {
        const int arrLen = 10000; //100000000
        const int maxNum = 500000;

        static System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        // однопоточный поиск
        static ArrayList Find(ArrayList arr)
        {
            double max1 = Math.Max(Convert.ToDouble(arr[0]), Math.Max(Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]))),
                max3 = Math.Min(Convert.ToDouble(arr[0]), Math.Min(Convert.ToDouble(arr[1]), Convert.ToDouble(arr[2]))),
                max2 = Convert.ToDouble(arr[0]) + Convert.ToDouble(arr[1]) + Convert.ToDouble(arr[2]) - max1 - max3;

            for (int i = 3; i < arr.Count; i++)
            {
                if (max1 < Convert.ToDouble(arr[i]))
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = Convert.ToDouble(arr[i]);
                }
                else if (max2 < Convert.ToDouble(arr[i]))
                {
                    max3 = max2;
                    max2 = Convert.ToDouble(arr[i]);
                }
                else if (max3 < Convert.ToDouble(arr[i]))
                {
                    max3 = Convert.ToDouble(arr[i]);
                }
            }

            ArrayList resultArr = new ArrayList();
            resultArr.Add(max1);
            resultArr.Add(max2);
            resultArr.Add(max3);

            return resultArr;
        }

        // многопоточный поиск
        static ArrayList FindP(ArrayList arr)
        {
            // разделяем один список на 4 части
            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            // доп потоки, можно удалить при надобности
            ArrayList arr3 = new ArrayList();
            ArrayList arr4 = new ArrayList();

            /*for (int i = 0; i < Convert.ToInt32(arr.Count/2); i++)
                arr1.Add(arr[i]);
            for (int i = Convert.ToInt32(arr.Count / 2); i < arr.Count; i++)
                arr2.Add(arr[i]);*/

            for (int i = 0; i < Convert.ToInt32(arr.Count / 4); i++)
                arr1.Add(arr[i]);
            for (int i = Convert.ToInt32(arr.Count / 4); i < Convert.ToInt32(arr.Count / 2); i++)
                arr2.Add(arr[i]);
            for (int i = Convert.ToInt32(arr.Count / 2); i < arr.Count - Convert.ToInt32(arr.Count / 4); i++)
                arr3.Add(arr[i]);
            for (int i = arr.Count - Convert.ToInt32(arr.Count / 4); i < arr.Count; i++)
                arr4.Add(arr[i]);

            // запускаем поиск одновременно на нескольких потоках
            Task<ArrayList>[] taskArray = { Task<ArrayList>.Factory.StartNew(() => Find(arr1)),
                                            Task<ArrayList>.Factory.StartNew(() => Find(arr2)),
                                            Task<ArrayList>.Factory.StartNew(() => Find(arr3)),
                                            Task<ArrayList>.Factory.StartNew(() => Find(arr4))};

            // объединяем результаты в один список и ищем среди них 3 max-числа
            for (int i = 0; i < taskArray[1].Result.Count; i++)
                taskArray[0].Result.Add(taskArray[1].Result[i]);
            for (int i = 0; i < taskArray[2].Result.Count; i++)
                taskArray[0].Result.Add(taskArray[2].Result[i]);
            for (int i = 0; i < taskArray[3].Result.Count; i++)
                taskArray[0].Result.Add(taskArray[3].Result[i]);
            ArrayList result = Find(taskArray[0].Result);

            return result;
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
            ArrayList resArr1 = Find(arr_copy);
            long TS = sw.ElapsedMilliseconds;
            Console.WriteLine("Числа найдены последовательно за {0} мс", TS);

            // запускаем параллельную реализацию
            sw.Restart();
            ArrayList resArr2 = FindP(arr_copy);
            TS = sw.ElapsedMilliseconds;
            Console.WriteLine("Числа найдены параллельно за {0} мс", TS);

            // вывод
            Console.WriteLine("\nПоследовательно: ");
            for (int i = 0; i < 3; i++)
                Console.Write("{0} ", resArr1[i]);

            Console.WriteLine("\nПараллельно: ");
            for(int i = 0; i < 3; i++)
                Console.Write("{0} ", resArr2[i]);

        }
    }
}
