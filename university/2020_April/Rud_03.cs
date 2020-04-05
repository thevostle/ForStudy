using System;

namespace Rud_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];

            matrix[0] = new int[5] { 1, 0, 1, 0, 1 };
            matrix[1] = new int[5] { 1, 0, 1, 1, 1 };
            matrix[2] = new int[5] { 0, 0, 0, 1, 0 };
            matrix[3] = new int[5] { 1, 0, 1, 1, 1 };
            matrix[4] = new int[5] { 1, 0, 1, 1, 1 };

            PrintTable(matrix);

            if (CheckTable(matrix))
                Console.WriteLine("В матрице существует колонна, состоящая из нулей");
            else
                Console.WriteLine("В матрице не существует колонны, состоящей из нулей");

            Console.ReadKey();
        }

        static bool CheckTable(int[][] matrix)
        {
            int count = 0;

            for (int x = 0; x < matrix.Length; x++)
            {
                bool flag = true;

                for (int y = 0; y < matrix.Length; y++) 
                { 
                    if (matrix[y][x] != 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    count++;
            }

            return count > 0;
        }

        static void PrintTable(int[][] table)
        {
            for (int y = 0; y < table.Length; y++)
            {
                for (int x = 0; x < table.Length; x++)
                    Console.Write(table[y][x] + " ");

                Console.WriteLine();
            }
        }
    }
}
