using System;

namespace NOD_NOK
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nНОК: " + NOK(a, b));
            Console.WriteLine("НОД: " + NOD(a, b));
            Console.ReadKey();
        }

        static int NOD (int a, int b)
        {
            for (int i = Math.Max(a, b); i > 0; i--)
            {
                if (a % i == 0 && b % i == 0) return i;
            }
            return 1;
        }

        static int NOK (int a, int b)
        {
            return (a * b) / NOD(a, b);
        }
    }
}
