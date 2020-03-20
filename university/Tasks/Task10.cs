using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMax = 1000;

            for (int i = 1; i <= numMax; i++)
            {
                if (isPerfect(i))
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        static bool isPerfect (int number)
        {
            int local = 0;

            while (number > 0)
            {
                number -= local;
                local++;
            }

            return number == 0;
        }
    }
}
