using System;

namespace Epifan_Course_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = {10, 2, 3, 5, 2, 6, 7, 4, 7, 8, 9, 7}; // можно изменить, отсюда будем брать числа

            int k = 5; // можно изменить, кол-во наибольших которые нам надо вывести
            int[] maxNums = new int[k]; // массив наибольших чисел

            Array.Copy(z, 0, maxNums, 0, k); // помещаем элементы z c нулевого в maxNums в индексы c 0 по k 

            for (int i = k; i < z.Length; i++) // просматриваем все числа в z
            {
                Array.Sort(maxNums); // сортируем maxNums
                if (z[i] > maxNums[0]) // если элемент из z больше, чем наименьший элемент maxNums...
                    maxNums[0] = z[i]; // заменяем этим элементом наименьший
            }

            foreach (int i in maxNums) // берем каждый элемент в maxNums 
                Console.WriteLine(i); // и выводим его
        }
    }
}
