using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Square
    {
        private double l;
        public Square()
        {
            Console.Write("Please enter the length of one side of the Square : ");
            l = UserInput.AcceptNumberInput();
        }
        public void PrintArea()
        { 
            double a = l * l;
            Console.WriteLine("Area of Square : " + a);
        }
    }
}
