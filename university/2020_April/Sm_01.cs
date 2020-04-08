using System;

namespace Sm_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[6][];

            matrix[0] = new int[6] { 5, 0, -1, 0, 1, 3 };
            matrix[1] = new int[6] { 1, 0, 1, 1, 1, 4 };
            matrix[2] = new int[6] { 0, 0, 5, 1, 6, 2 };
            matrix[3] = new int[6] { 1, 3, -1, 4, 1, 3 };
            matrix[4] = new int[6] { 1, 0, -1, 1, 1, 3 };
            matrix[5] = new int[6] { 1, 5, 4, 9, 1, 3 };

            PrintTable(matrix);

            Console.WriteLine("Кол-во рядов без нулей: " + GetRowsWithoutZero(matrix));
            Console.WriteLine("Максимальное повторяющееся число: " + GetMaxNumbers(MakeArray(matrix)));

            Console.ReadKey();
        }

        static void PrintTable(int[][] table)
        {
            Console.WriteLine();
            for (int y = 0; y < table.Length; y++)
            {
                for (int x = 0; x < table[y].Length; x++)
                    Console.Write(table[y][x] + "\t");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int GetRowsWithoutZero (int [][] table)
        {
            int count = 0;

            for (int y = 0; y < table.Length; y++)
            {
                bool flag = true;
                for (int x = 0; x < table[y].Length; x++)
                {
                    if (table[y][x] == 0)
                        flag = false;
                }

                if (flag)
                    count++;
            }
            return count;
        }

        static int GetMaxNumbers (int[] array)
        {
            int[] sortedArray = array;
            Sort(sortedArray);

            // на случай, если маскимальные числа не будут повторяться, инициализируем max, как максимальное число в массиве + 1
            int error = sortedArray[sortedArray.Length - 1] + 1; 

            for (int i = sortedArray.Length - 1; i > 1; i--)
                if (sortedArray[i] == sortedArray[i - 1])
                    return sortedArray[i];

            Console.Write("повторяющихся чисел нет ");
            return error;
        }

        static int[] MakeArray (int[][] table)
        {
            int[] array = new int[table.Length * table[0].Length];

            for (int y = 0; y < table.Length; y++)
                for (int x = 0; x < table[y].Length; x++)
                    array[table.Length * y + x] = table[y][x];

            return array;
        }

        static void Sort (int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
