using System;

namespace Rud_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { {0, 1, 1, 3, 1, 1},
                              {1, 0, 1, 3, 3, 1 },
                              {1, 1, 0, 1, 3, 0 },
                              {0, 0, 1, 0, 1, 0 },
                              {1, 0, 0, 1, 0, 0 },
                              {1, 1, 3, 3, 3, 0 } };

            PrintTable(matrix);

            Console.WriteLine("Кол-во комманд без поражений: ");
            GetWinTeams(matrix);
            Console.ReadKey();
        }

        static void PrintTable(int[,] table)
        {
            int len = Convert.ToInt32(Math.Sqrt(table.Length));

            Console.WriteLine();
            for (int y = 0; y < len; y++)
            {
                for (int x = 0; x < len; x++)
                    Console.Write(table[y,x] + "\t");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void GetWinTeams(int[,] table)
        {
            int len = Convert.ToInt32(Math.Sqrt(table.Length));
            for (int team = 0; team < len; team++)
            {
                bool flag = true;
                for (int enemy = 0; enemy < len; enemy++)
                {
                    if (enemy != team)
                    {
                        if (table[team, enemy] == 0)
                            flag = false;
                    }
                }

                if(flag)
                    Console.WriteLine(team+1);
            }
        }
    }
}
