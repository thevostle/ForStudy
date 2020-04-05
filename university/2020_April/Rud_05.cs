using System;

namespace Rud_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[6][];

            matrix[0] = new int[6] { 1, 0, -1, 0, 1, 3 };
            matrix[1] = new int[6] { -1, -3, -1, -1, 1, -3 };
            matrix[2] = new int[6] { 0, 0, 0, 1, 0, 3 };
            matrix[3] = new int[6] { 1, 0, -1, 1, 1, 3 };
            matrix[4] = new int[6] { -1, -2, -1, -1, -1, -3 };
            matrix[5] = new int[6] { 1, 0, 1, 1, 1, 3 };

            PrintTable(matrix);


            Console.WriteLine("\nМинимальный ряд из отрицательных чисел: " + GetRow(matrix));

            Console.ReadKey();
        }

        static int GetRow(int[][] matrix)
        {
            for (int y = 0; y < matrix.Length; y++)
            {
                bool flag = true;

                for (int x = 0; x < matrix.Length; x++)
                {
                    if (matrix[y][x] > 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    return y;
            }

            return -1;
        }

        static void PrintTable(int[][] table)
        {
            for (int y = 0; y < table.Length; y++)
            {
                for (int x = 0; x < table.Length; x++)
                    Console.Write(table[y][x] + "\t");

                Console.WriteLine();
            }
        }
    }
}
