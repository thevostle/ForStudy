using System;

namespace Epifan_Course_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 5;

            double[,] a = { { 0.5, 1, 2, 4.6, 3 }, { 7, 4, 5, 4.3, 7}, { 6, 6, 7, 3.2, 4} };

            int[] mins = new int[m];

            double minInGrid = float.MaxValue;
            
            for (int y = 0; y < m; y++)
            {
                int minX = 0;
                minInGrid = a[y, 0];
                for (int x = 0; x < n; x++)
                {
                    if (a[y, x] < minInGrid)
                    {
                        minInGrid = a[y, x];
                        minX = x;
                    }
                }
                mins[y] = minX;
            }

            foreach (int i in mins)
                Console.WriteLine(i);
        }
    }
}
