using System;

namespace Epifan_Course_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[20];
            for (int i = 0; i < 20; i++)
            {
                a[i] = rnd.Next(0, 50);
                Console.Write(a[i] + " ");
            }

            Console.WriteLine("\n");
            for (int i = 1; i < a.Length-1; i++)
                if (a[i - 1] < a[i] && a[i] < a[i + 1])
                    Console.WriteLine(a[i]);
        }
    }
}
