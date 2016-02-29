using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Triangle
    {
        private double b,h;
        public Triangle()
        {
            Console.Write("Please enter the base of the Triangle : ");
            b = UserInput.AcceptNumberInput();
            Console.Write("Please enter the height of the Triangle : ");
            h = UserInput.AcceptNumberInput();
        }
        public void PrintArea()
        {
            double a = (b * h) / 2;
            Console.WriteLine("Area of Triangle : " + a);
        }
    }
}
