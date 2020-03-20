using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите 1-ое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            b = Convert.ToInt32(Console.ReadLine());

            int result = NOD(a, b);

            Console.WriteLine("\nНОД: " + result);
            Console.WriteLine("Введенный вариант: {0}/{1}", a, b);

            Console.Write("Сокращенный вариант: ");
            if (b / result == 1)
                Console.Write(a / result);
            else
                Console.Write("{0}/{1}", a / result, b / result);

            Console.ReadKey();
        }

        static int NOD(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
    }
}
