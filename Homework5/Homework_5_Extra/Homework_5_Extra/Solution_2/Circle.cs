using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Circle
    {
        private double area, dimension;
        private string strInput;

        public Circle()
        {
            while (true)
            {
                Console.Write("Type of value being entered (Dimension / Area): ");
                strInput = Console.ReadLine();
                if (strInput.ToLower() == "area" || strInput.ToLower() == "dimension")
                    break;
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
            if (strInput.ToLower() == "area")
            {
                Console.Write("Enter the area of circle: ");
                area = UserInput.AcceptNumberInput();
            }
            else if (strInput.ToLower() == "dimension")
            {
                Console.Write("Enter the dimension of circle : ");
                dimension = UserInput.AcceptNumberInput();
            }
           
        }
        public void PrintAreaOrDimension()
        {
            if (strInput.ToLower() == "area")
            {
                dimension = (double)(Math.Sqrt(area / Math.PI));
                Console.WriteLine("Dimension of circle : " + dimension);
            }
            else if (strInput.ToLower() == "dimension")
            {
                area = (double)Math.PI * dimension * dimension;
                Console.WriteLine("Area of Circle : " + area);
            }
        }
    }
}
