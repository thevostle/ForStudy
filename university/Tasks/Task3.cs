using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 0, 5, 25, 125, -5, 2, 10 }; // 4 степени п€терки

            Console.WriteLine(" ол-во чисел - степеней п€терки: " + Count(a));
            Console.ReadKey();
        }

        static int Count(int[] array)
        {
            int result = 0;
            foreach (int i in array)
            {
                int local = i;
                while (local / 5 > 0)
                    local /= 5;
                if (local == 1)
                    result++;
            }

            return result;
        }
    }
}