using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Triangle
    {
        private int b,h;
        public Triangle()
        {
            Console.Write("Please enter the base of the Triangle : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the height of the Triangle : ");
            h = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintArea()
        {
            int a = (b * h) / 2;
            Console.WriteLine("Area of Triangle : " + a);
        }

    }
}
