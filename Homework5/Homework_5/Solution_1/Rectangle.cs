using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Rectangle
    {
        private int l,b;
        public Rectangle()
        {
            Console.Write("Please enter the length of the Rectangle : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the breadth of the Rectangle : ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintArea()
        {
            int a = l * b;
            Console.WriteLine("Area of Rectangle : " + a);
        }
    }
}
