using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Rectangle
    {
        private double l,b;
        public Rectangle()
        {
            Console.Write("Please enter the length of the Rectangle : ");
            l = UserInput.AcceptNumberInput();
            Console.Write("Please enter the breadth of the Rectangle : ");
            b = UserInput.AcceptNumberInput();
        }
        public void PrintArea()
        {
            double a = l * b;
            Console.WriteLine("Area of Rectangle : " + a);
        }
    }
}
