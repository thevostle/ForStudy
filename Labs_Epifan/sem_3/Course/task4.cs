using System;

namespace Epifan_Course_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); /// готовим модуль рандомной генерации
            int[] a = new int[20]; // готовим массив
            for (int i = 0; i < 20; i++)
            {
                a[i] = rnd.Next(0, 50); // заполняем его рандомными числами от 0 до 50
                Console.Write(a[i] + " "); // выводим их
            }

            Console.WriteLine("\n"); // новая строка
            for (int i = 1; i < a.Length-1; i++) // просматриваем все числа
                if (a[i - 1] < a[i] && a[i] < a[i + 1]) // если число больше предыдущего и меньше следующего...
                    Console.WriteLine(i); // выводим его ИНДЕКС
        }
    }
}
