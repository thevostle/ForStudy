using System;

namespace MyProgram
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
}
