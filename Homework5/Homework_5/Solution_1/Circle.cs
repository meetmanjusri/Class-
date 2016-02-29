using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Circle
    {
        private double r;
        public Circle()
        {
            Console.Write("Please enter the radius of the circle : ");
            r = UserInput.AcceptNumberInput();
        }
        public void PrintArea()
        {
            double a = (double)Math.PI * r * r;
            Console.WriteLine("Area of Circle : " + a);
        }
    }
}

    

