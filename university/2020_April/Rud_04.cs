using System;

namespace Rud_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[6][];

            matrix[0] = new int[6] { 1, 0, -1, 0, 1, 3 };
            matrix[1] = new int[6] { 1, 0, 1, 1, 1, 3 };
            matrix[2] = new int[6] { 0, 0, 0, 1, 0, 3 };
            matrix[3] = new int[6] { 1, 0, -1, 1, 1, 3 };
            matrix[4] = new int[6] { 1, 0, -1, 1, 1, 3 };
            matrix[5] = new int[6] { 1, 0, 1, 1, 1, 3 };

            PrintTable(matrix);

            if (CheckTable(matrix))
                Console.WriteLine("\nВ матрице существует столбец с равным кол-вом + и - чисел");
            else
                Console.WriteLine("\nВ матрице не существует столбец с равным кол-вом + и - чисел");

            Console.ReadKey();
        }

        static bool CheckTable(int[][] matrix)
        {
            for (int x = 0; x < matrix.Length; x++)
            {
                int num_minus = 0;
                int num_plus = 0;

                for (int y = 0; y < matrix.Length; y++)
                {
                    if (matrix[y][x] >= 0)
                        num_plus++;
                    else
                        num_minus++;
                }

                if (num_minus == num_plus)
                    return true;
            }

            return false;
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
