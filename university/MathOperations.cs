using System;

namespace CW_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1.24323, 0.32));
            Console.WriteLine(Sub(1, 0.32));
            Console.WriteLine(Multiply(2222222222, 2));
            Console.WriteLine(Divide(2222222222, 2));
            Console.WriteLine(Pow(3, 3));
            Console.WriteLine(Factorial(5));
        }



        static double Sum(double x1, double x2) // сложение
        {
            return x1 + x2;
        }

        static double Sub(double x1, double x2) // вычитание
        {
            return x1 - x2;
        }

        static double Multiply(double x1, double x2) // умножение
        {
            return x1 * x2;
        }

        static double Divide(double x1, double x2) // деление
        {
            return x1 / x2;
        }

        static double Pow(double x, int pow) // возведение в степень
        {
            double result = x;

            if (pow == 0)
                return 1;

            for (int i = 1; i < pow; i++)
                result *= x;

            return result;
        }

        static int Factorial(int x) // факториал
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }
    }
}
