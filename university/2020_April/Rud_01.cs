using System;

namespace Rud_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];

            matrix[0] = new int[5] { 1, 1, 1, 1, 1 };
            matrix[1] = new int[5] { 1, 1, 1, 1, 1 };
            matrix[2] = new int[5] { 1, 1, 1, 1, 1 };
            matrix[3] = new int[5] { 1, 1, 1, 1, 1 };
            matrix[4] = new int[5] { 1, 1, 1, 1, 1 };

            PrintTable(matrix);

            if (CheckRows(matrix) && CheckCollumns(matrix) && CheckDiag(matrix))
                Console.WriteLine("\nМатрица является магической");
            else
                Console.WriteLine("\nМатрица не является магической");

            Console.ReadKey();
        }

        static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
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

        static bool CheckRows(int[][] matrix)
        {
            bool result = true;

            int first = SumArray(matrix[0]);

            foreach (int[] row in matrix)
            {
                if (SumArray(row) != first)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static bool CheckCollumns(int[][] matrix)
        {
            int[][] m = new int[matrix.Length][];

            for (int x = 0; x < matrix.Length; x++)
            {
                int[] col = new int[matrix.Length];

                for (int y = 0; y < matrix.Length; y++)
                    col[x] = matrix[x][y];

                m[x] = col;
            }

            return CheckRows(m);
        }

        static bool CheckDiag(int[][] matrix)
        {
            int y = 0;
            int[] d1 = new int[matrix.Length];
            for (int x = 0; x < matrix.Length; x++, y++)
                d1[x] = matrix[y][x];

            y = 0;
            int[] d2 = new int[matrix.Length];
            for (int x = matrix.Length-1; x >-1; x--, y++)
                d2[y] = matrix[y][x];

            return SumArray(d1) == SumArray(d2);            
        }
    }
}
