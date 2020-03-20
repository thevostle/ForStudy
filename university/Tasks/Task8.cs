using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 6, 2, 4, 8, 10, 2 }; // ответ: 2

            int NOD_memory = NOD(numbers[0], numbers[1]);
            for (int i = 2; i < numbers.Length; i++)
            {
                NOD_memory = NOD(NOD_memory, numbers[i]);
            }

            Console.WriteLine(NOD_memory);
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
