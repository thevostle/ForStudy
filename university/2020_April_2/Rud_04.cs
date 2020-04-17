using System;

namespace Rud_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            text = Console.ReadLine();

            Console.WriteLine("Сумма цифр: " + Sum(text));
            Console.ReadKey();
        }

        static int Sum(string text)
        {
            int sum = 0;

            for (int i = 0; i < text.Length; i++) 
            { 
                int s = Convert.ToInt32(text[i]);
                if (s >= 48 && s <= 57)
                    sum += (s-48);
            }

            return sum;
        }
    }
}
