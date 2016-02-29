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
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = double.TryParse(strInput, out r);
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
            double a = (double) Math.PI * r * r;
            Console.WriteLine("Area of Circle : " + a);
        }
    }
}

    

