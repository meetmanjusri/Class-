using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Square
    {
        private double area, dimension;
        private string strInput;
        public Square()
        {
            Console.Write("Type of value being entered (Dimension / Area): ");
            strInput = Console.ReadLine();
            if (strInput.ToLower() == "area")
            {
                Console.Write("Please enter the area of a square: ");
                area = UserInput.AcceptNumberInput();
            }
            else if (strInput.ToLower() == "dimension")
            {
                Console.Write("Please enter the length of side of a square: ");
                dimension = UserInput.AcceptNumberInput();
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
        public void PrintAreaOrDimension()
        {
            if (strInput.ToLower() == "area")
            {
                dimension = (double)(Math.Sqrt(area));
                Console.WriteLine("Dimension of a square : " + dimension);
            }
            else if (strInput.ToLower() == "dimension")
            {
                area = (double)dimension * dimension;
                Console.WriteLine("Area of a square : " + area);
            }
        }
    }
}
