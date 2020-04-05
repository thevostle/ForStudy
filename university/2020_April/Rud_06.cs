// Программа не работает!!!
// Rud_06 Studio v0.1 alpha



using System;

namespace Rud_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[6][];

            matrix[0] = new int[6] { 1, 1, 2, 2, 1, 1 };
            matrix[1] = new int[6] { 2, 2, 3, 3, 1, 8 };
            matrix[2] = new int[6] { 3, 3, 4, 4, 0, 5 };
            matrix[3] = new int[6] { 4, 4, 2, 2, 1, 3 };
            matrix[4] = new int[6] { 5, 5, 3, 3, 9, 5 };
            matrix[5] = new int[6] { 6, 6, 4, 4, 1, 3 };

            PrintTable(matrix);
            RecreateMatrix(matrix);
            PrintTable(matrix);

            Console.ReadKey();
        }

        static void PrintTable(int[][] table)
        {
            Console.WriteLine();
            for (int y = 0; y < table.Length; y++)
            {
                for (int x = 0; x < table.Length; x++) 
                    Console.Write(table[y][x] + "\t");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void RecreateMatrix(int[][] table)
        {
            int len = table.Length - 1;
            int[][] copy = table;

            for (int x = 0; x < table.Length; x++)
                if (x % 2 == 1)
                    for (int y = 0; y < len; y++)
                        table[y][x] = copy[len-y][x];
            
        }
    }
}
