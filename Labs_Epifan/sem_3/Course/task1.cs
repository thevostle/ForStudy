using System;

namespace Epifan_Course_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] z = {10, 2, 3, 5, 2, 6, 7, 4, 7, 8, 9, 7};

            int k = 5;
            int[] maxNums = new int[k];

            Array.Copy(z, 0, maxNums, 0, k);

            for (int i = 0; i < z.Length; i++)
            {
                Array.Sort(maxNums);
                if (z[i] > maxNums[0]) 
                    maxNums[0] = z[i];
            }

            foreach (int i in maxNums)
                Console.WriteLine(i);
        }
    }
}
