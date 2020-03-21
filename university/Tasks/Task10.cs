using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMax = 1000;

            for (int i = 1; i <= numMax; i++)
                if (isPerfect(i))
                    Console.WriteLine(i);

            Console.ReadKey();
        }

        static bool isPerfect (int number)
        {
            int sum = 1;
            if (number == 1) return false;
            for (int i = 2; i <= (number / 2); i++)
                if (number % i == 0) sum = sum += i;
            return sum == number;
        }
    }
}
