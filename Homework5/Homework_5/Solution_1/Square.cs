using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Square
    {
        private int l;
        public Square()
        { 
            Console.Write("Please enter the length of one side of the Square : ");
            l = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintArea()
        { 
            int a = l * l;
            Console.WriteLine("Area of Square : " + a);
        }
    }
}
