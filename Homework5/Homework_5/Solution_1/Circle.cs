using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Circle
    {
        private int r;
        public Circle()
        {
            Console.Write("Please enter the radius of the circle : ");
            r = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintArea()
        {
            Double a = (3.14) * r * r;
            Console.WriteLine("Area of Circle : " + a);
        }
    }
}

    

