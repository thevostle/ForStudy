using System;

namespace MyProgram
{
    class Program
    {
        static void Main()
        {
            Circle oneCircle = new Circle(-1);
            oneCircle.Show();
            Console.WriteLine();

            oneCircle.X = -1; // параметр value принимает значение -1    
            oneCircle.Y = 1; // параметр value принимает значение 1    
            oneCircle.Radius = 2; // параметр value принимает значение 2    
            oneCircle.Show();
            Console.WriteLine("Заданная {0} имеет площадь {1:f}", oneCircle.Name, oneCircle.Area);
        }
    }
}
