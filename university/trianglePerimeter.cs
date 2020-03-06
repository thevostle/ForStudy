using System;

namespace trianglePerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] c; // координаты
            c = new double[6];

            // ввод координат: x1, x2, x3, y1, y2, y3
            for (int i = 0; i <= 5; i++)
            {
                if (i > 2) Console.Write("Y{0}: ", i-2);
                else Console.Write("X{0}: ", i+1);
                c[i] = double.Parse(Console.ReadLine());
            }

            double p; // периметр
            p = perimeter(lineLenght(c[0], c[3], c[1], c[4]), lineLenght(c[1], c[4], c[2], c[5]), lineLenght(c[2], c[5], c[0], c[3]));

            Console.WriteLine("\nПериметр треугольника: " + p);
            Console.ReadKey();
        }

        public static double lineLenght(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
        }

        public static double perimeter(double side_x, double side_y, double side_z)
        {
            return side_x + side_y + side_z;
        }
    }
}
