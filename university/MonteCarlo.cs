using System;

namespace Area_MonteCarlo
{
    class MonteCarlo
    {
        static void Main(string[] args)
        {
            double r;
            long accuracy;

            Console.WriteLine("Введите радиус: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите кол-во точек для вычисления площади (чем больше точек - тем точнее): ");
            accuracy = Convert.ToInt64(Console.ReadLine());

            calculate(accuracy, r);

            Console.ReadKey();
        }
        
        // true, если фигура содержит данную точку
        // иначе, результат - false
        static bool check(double x, double y, double r)
        {
            bool inArea = false;

            if (Math.Abs(x) <= r && Math.Abs(y) <= r)
            {
                if (x <= 0)
                { 
                    if (Math.Pow(x+r, 2) + Math.Pow(y-r, 2) >= Math.Pow(r, 2))
                        inArea = true;
                }
                else if (x >= 0)
                {
                    if (Math.Pow(x-r, 2) + Math.Pow(y+r, 2) >= Math.Pow(r, 2))
                        inArea = true;
                }
            }

            return inArea;
        }

        static void calculate(long count, double r)
        {
            long target = 0;
            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                double x = GetRandomNumber(-r, r);
                double y = GetRandomNumber(-r, r);
                if (check(x, y, r) == true)
                    target++;
            }

            double area = (Convert.ToDouble(target) / count * Math.Pow(r, 2));
            double chance = 1.0 / count; 

            Console.WriteLine("\nПлощадь фигуры: " + area);
            Console.WriteLine("Погрешность: " + chance);
        }

        static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
