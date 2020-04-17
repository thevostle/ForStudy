// Дан текст. Проверить правильно ли в нем записаны буквосочетания ЖИ-ШИ.

using System;

namespace Rud_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            text = Console.ReadLine();

            Console.WriteLine("Корректность ЖИ-ШИ: " + Check(text));
            Console.ReadKey();
        }

        static bool Check(string text)
        {
            bool flag = true;
            string str = text.ToLower();

            for (int i = 0; i < text.Length - 1; i++)
                if ((str[i] == 'ж' || str[i] == 'ш') && str[i + 1] == 'ы')
                    flag = false;

            return flag;
        }
    }
}
