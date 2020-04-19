// В заданной строке удалить все пробелы

using System;

namespace Rud_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            text = Console.ReadLine();

            Console.WriteLine(DeleteSpaces(text));
            Console.ReadKey();
        }

        static string DeleteSpaces(string text)
        {
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == ' ' && text[i + 1] == ' ') 
                { 
                    text = text.Remove(i, 1);
                    i = 0;
                }
            }

            return text;
        }
    }
}
