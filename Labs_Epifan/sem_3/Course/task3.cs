using System;

namespace Epifan_Course_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[64];
            double[,] a = new double[8,8];

            Random rng = new Random();
            for (int i = 0; i < 64; i++)
                arr[i] = i;
                //arr[i] = rng.NextDouble();

            for (int i = 0; i < 64; i++)
                Console.WriteLine(arr[i]);

            for (int y = 0; y < 8; y++)
            {
                if (y % 2 == 1)
                    for (int x = 0; x < 8; x++)
                        a[y, x] = arr[y * 8 + x];
                else
                    for (int x = 8; x > 0; x--)
                        a[y, x-1] = arr[y * 8 + 8 - x];
            }

            Console.WriteLine();

            for (int y = 0; y < 8; y++) 
            { 
                for (int x = 0; x < 8; x++) 
                { 
                    Console.Write(a[y,x]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
