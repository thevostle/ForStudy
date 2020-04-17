// Дано предложение. В нем слова разделены одним или несколькими пробелами.
// Определить количество слов в предложении.

using System;

namespace Rud_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            text = Console.ReadLine();

            Console.WriteLine("Кол-во слов в предложении: " + wordCounter(text));
            Console.ReadKey();
        }

        static int wordCounter(string text)
        {
            int count = 0;
            if (text[0] != ' ')
                count++;

            for (int i = 0; i < text.Length-1; i++)
                if (text[i] == ' ' && text[i + 1] != ' ')
                    count++;

            return count;
        }
    }
}
