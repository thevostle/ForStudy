// дан текст, имеющиий вид d1 +- d2 +- ... +- dn, где di - натуральные цифры.
// Вычислить записанную в тексте алгебраическую сумму.

using System;

namespace Rud_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            text = Console.ReadLine();

            Console.WriteLine("Алгебраическая сумма: " + Sum(text));
            Console.ReadKey();
        }

        static int Sum(string text)
        {
            int sum = Convert.ToInt32(text[0]) - 48;

            for (int i = 1; i+1 < text.Length; i += 2)
            {
                int num = Convert.ToInt32(text[i]);
                if (text[i] == '+')
                    sum += (text[i + 1] - 48);
                else if (text[i] == '-')
                    sum -= (text[i + 1] - 48);
            }

            return sum;
        }
    }
}
