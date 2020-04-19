// Дано предложение. Найти длину его самого короткого слова.

using System;

namespace Rud_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            text = Console.ReadLine();

            Console.WriteLine("Размер наименьшего слова: " + wordLen(text));
            Console.ReadKey();
        }

        static int wordLen(string text)
        {
            int minLenght = text.Length;

            for (int i = 0; i < text.Length; i++) 
            {
                int lenght = 0;
                while (text[i] != ' ' && i != text.Length-1)
                {
                    lenght++;
                    if (i == text.Length - 2 && text[i+1] != ' ' && lenght < minLenght)
                        lenght++;
                    i++;
                }

                if (lenght < minLenght)
                    minLenght = lenght;
            }

            if (text.Length > 1)
                if (text[text.Length - 2] == ' ' && text[text.Length - 1] != ' ')
                    return 1;

            if (text.Length == 1)
                return 1;

            return minLenght;
        }
    }
}
