using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Большее кол-во цифр в числе " + Select(a, b));
            Console.ReadKey();
        }

        static int Count(int num)
        {
            int result = 0;

            while (num > 0)
            {
                result++;
                num /= 10;
            }

            return result;
        }

        static int Select(int a, int b)
        {
            if (Count(a) >= Count(b))
                return a;
            else
                return b;
        }
    }
}
