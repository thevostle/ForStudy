using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram
{
    class Circle
    {
        public int x = 0;
        public int y = 0;
        public int radius = 3;
        public const double pi = 3.14;
        public static readonly string name = "Окружность";

        public void Set(int x, int y, int radius)
        {
            //использует параметр this для обращения к полям класса, т.к. их имена     
            // совпадают с именами параметров метода    

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
