using System;

namespace Rud_09
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

            Console.WriteLine("Команда-Чемпион: " + GetBestTeam(matrix));
            
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

        static int GetBestTeam(int[,] table)
        {
            int len = Convert.ToInt32(Math.Sqrt(table.Length));
            int[] stats = new int[len];

            for (int team = 0; team < len; team++)
                for (int enemy = 0; enemy < len; enemy++)
                    stats[team] += table[team, enemy];

            // получаем наибольшее кол-во очков
            int maxScore = 0;
            int maxTeamIndex = 0;
            for (int teamIndex = 0; teamIndex < len; teamIndex++)
            { 
                if (stats[teamIndex] >= maxScore) 
                { 
                    maxScore = stats[teamIndex];
                    maxTeamIndex = teamIndex;
                }
            }

            return maxTeamIndex+1;
        }
    }
}
