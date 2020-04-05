using System;

namespace Rud_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];

            matrix[0] = new int[5] { 0, 1, 1, 2, 0 };
            matrix[1] = new int[5] { 1, 1, 1, 1, 3 };
            matrix[2] = new int[5] { 1, 1, 7, 1, 1 };
            matrix[3] = new int[5] { 2, 1, 1, 1, 1 };
            matrix[4] = new int[5] { 0, 3, 1, 1, 5 };

            PrintTable(matrix);

            if (CheckSymmetry(matrix))
                Console.WriteLine("Матрица симметрична");
            else
                Console.WriteLine("Матрица не симметрична");

            Console.ReadKey();
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

        static bool CheckSymmetry(int[][] table)
        {
            bool flag = true;
            int len = table.Length;

            for (int k = 0; k < len - 1; k++)
                for (int l = k + 1; l < len; l++)
                    if (table[k][l] != table[l][k])
                    {
                        flag = false;
                        break;
                    }

            return flag;
        }
    }
}
