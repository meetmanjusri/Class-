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
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = double.TryParse(strInput, out l);
                if (isSuccess)
                    break;
                else
                {
                    Console.Write("Value entered is not a number. Please retry again: ");
                }

            }
            Console.Write("Please enter the breadth of the Rectangle : ");
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = double.TryParse(strInput, out b);
                if (isSuccess)
                    break;
                else
                {
                    Console.Write("Value entered is not a number. Please retry again: ");
                }
            }
        }
        public void PrintArea()
        {
            double a = l * b;
            Console.WriteLine("Area of Rectangle : " + a);
        }
    }
}
