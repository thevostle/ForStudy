using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во чисел-близнецов: " + PrimeNumberArray(200));
            Console.ReadKey();
        }

        static int PrimeNumberArray (int count)
        {
            int result = 0;
            int memory = 2; 

            for (int i = 2; i < count; ++i)
            {
                bool isPrime = true;

                for (int j = 2; j * j <= i; ++j)
                { 
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                
                }

                if (isPrime)
                {
                    if (i - memory == 2)
                        result++;
                    memory = i;
                }
            }
            return result;
        }
    }
}
