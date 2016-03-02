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
                Console.Write("Please enter the length of side of a square: ");
                dimension = UserInput.AcceptNumberInput();
            }
            else if (strInput.ToLower() == "dimension")
            {
                Console.Write("Please enter the length of side of a square: ");
                area = UserInput.AcceptNumberInput();
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
                area = (double) dimension*dimension;
                Console.WriteLine("Area of a square : " + area);
            }
            else if (strInput.ToLower() == "dimension")
            {
                dimension = (double) (Math.Sqrt(area));
                Console.WriteLine("Dimension of a square : " + dimension);
            }
        }
    }
}
