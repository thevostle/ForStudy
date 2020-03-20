using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введите десятичное число: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Результат: " + ConvertToBin(number));
            Console.ReadKey();
        }

        static int ConvertToBin(int number)
        {
            int result = 0, d = 1;

            while (number > 0)
            {
                result += (number % 2) * d;
                number /= 2;
                d = d * 10;
            }

            return result;
        }
    }
}
