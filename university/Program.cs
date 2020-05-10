using System;

namespace University_CircleClass
{    
    class Program 
    { 
        static void Main()
        { 
            Circle oneCircle = new Circle(); 
            oneCircle.Show(); 
            oneCircle.Set(1, 1, 100); 
            oneCircle.Show(); 
        } 
    }

    class Circle
    {
        public int x = 0;
        public int y = 0;
        public int radius = 3;
        public const double pi = 3.14;
        public static readonly string name = "Окружность";

        public void Set(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public void Show()
        {
            Console.WriteLine("{0} с центром  в точке ({1},{2}) радиусом {3}", name, x, y, radius);
        }
    }
}
