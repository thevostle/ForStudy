// Дан текст. Определить, сколько в нем предложений.

using System;

namespace Rud_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            text = Console.ReadLine();

            Console.WriteLine("Кол-во предложений в тексте: " + Counter(text));
            Console.ReadKey();
        }

        static int Counter(string text)
        {
            int count = 0;
            if (text[0] != '.')
                count++;

            for (int i = 0; i < text.Length-1; i++)
                if (text[i] == '.' && text[i + 1] != '.')
                    count++;

            return count;
        }
    }
}
