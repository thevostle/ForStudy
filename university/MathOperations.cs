using System;

namespace CW_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            // ввод данных
            Console.WriteLine("Введите число x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            


            /*    Если программа вычисляет факториал, то ввод данных заменить на...
             *    
             *    Console.WriteLine("Введите число x (до 25): ");
             *    long x = Convert.ToInt64(Console.ReadLine());
             *    
             *    x2 не нужен, а X является long переменной.
             *    если х > 25, он переполняет тип, и результат становится отрицательным.
             */




            /*    Если программа вычисляет степени, то ввод данных заменить на...
             *    
             *   Console.WriteLine("Введите число x1: ");
             *   double x1 = Convert.ToDouble(Console.ReadLine());
             *   Console.WriteLine("Введите число x2 (степень): ");
             *   long x2 = Convert.ToInt64(Console.ReadLine());
             */




            Console.WriteLine("Результат:\n");
            Console.WriteLine(Sum(x1, x2));
            Console.WriteLine(Sub(x1, x2));
            Console.WriteLine(Multiply(x1, x2));
            Console.WriteLine(Divide(x1, x2));
            //Console.WriteLine(Pow(x1, x2));
            //Console.WriteLine(Factorial(x));
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

        static double Pow(double x, long pow) // возведение в степень
        {
            double result = x;

            if (pow == 0)
                return 1;

            for (long i = 1; i < pow; i++)
                result *= x;

            return result;
        }

        static long Factorial(long x) // факториал
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }
    }
}
