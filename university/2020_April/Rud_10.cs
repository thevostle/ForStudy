using System;

namespace Rud_10
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

            if (TeamDestroyer(matrix))
                Console.WriteLine("Есть команда, победившая в большей части матчей");
            else
                Console.WriteLine("Отсутствует команда, победившая в большей части матчей");

            Console.ReadKey();
        }

        static void PrintTable(int[,] table)
        {
            int len = Convert.ToInt32(Math.Sqrt(table.Length));

            Console.WriteLine();
            for (int y = 0; y < len; y++)
            {
                for (int x = 0; x < len; x++)
                    Console.Write(table[y, x] + "\t");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static bool TeamDestroyer(int[,] table)
        {
            int len = Convert.ToInt32(Math.Sqrt(table.Length));
            bool haveTeamDestroyer = false;

            for (int team = 0; team < len; team++) 
            {
                int wins = 0;
                for (int enemy = 0; enemy < len; enemy++)
                {
                    if (table[team, enemy] == 3)
                        wins++;
                }

                if (wins > (len-1) / 2)
                    haveTeamDestroyer = true;
            }

            return haveTeamDestroyer;
        }
    }
}
