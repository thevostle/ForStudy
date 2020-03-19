using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 3, 9, 25, 7, 8, 7, -9, 0 }; // 5 квадратов

            Console.WriteLine("Полных квадратов: " + Count(a));
            Console.ReadKey();
        }

        static int Count(int[] array)
        {
            int result = 0;

            foreach (int i in array)
                if (i >= 0)
                    if (Math.Sqrt(i) == Convert.ToInt32(Math.Sqrt(i)))
                        result++;

            return result;
        }
    }
}
