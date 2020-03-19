using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Большая сумма цифр в числе " + Select(a, b));
            Console.ReadKey();
        }

        static int Sum (int num)
        {
            int result = 0;

            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }

            return result;
        }

        static int Select (int a, int b)
        {
            if (Sum(a) >= Sum(b))
                return a;
            else
                return b;
        }
    }
}
