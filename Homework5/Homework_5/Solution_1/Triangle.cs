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
            Console.Write("Please enter the height of the Triangle : ");
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = double.TryParse(strInput, out h);
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
            double a = (b * h) / 2;
            Console.WriteLine("Area of Triangle : " + a);
        }

    }
}
