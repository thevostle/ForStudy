using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram
{
    class Circle
    {
        //теперь поля закрыты и доступ из другого класса к ним невозможен   
        private int x;   
        private int y;   
        private int radius;  
        
        static readonly string name="Окружность";     
        
        public Circle(int radius)   
        {    
            //устанавливаем поле radius через одноименное свойство, для проверки     
            // допустимости устанавливаемого значения     
            Radius= radius;    
        } 

        public Circle(int x, int y, int radius) : this(radius) 
        { 
            this.x = x; 
            this.y = y; 
        } 

        public void Show() 
        { 
            Console.WriteLine("{0} с центром  в точке ({1},{2}), радиусом {3}", name, x, y, radius); 
        }

        public int X { get; set; }
        public int Y { get; set; }


        public int Radius  //свойство для обращения к полю radius   
        {    
            get     
            {      
                return radius;    
            }    
            set     
            {     
                if (value>0)     
                {      
                    radius = value;     
                }     
                else      
                {      
                    radius=0;      
                    Console.WriteLine("Недопустимое значение для радиуса окружности {0}", value);     
                }    
            }   
        } 

        public string Name  //свойство для работы с закрытым readonly полем    
        {    
            get    
            {     
                return name; 
            }
        }

        public double Area  // свойство доступное только для чтения   
        {    
            get    
            {     
                return Math.PI * radius * radius;    
            }   
        }  
    }
}
