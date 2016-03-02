using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the type of shape (Circle / Square / Quit): ");
                string strInput = Console.ReadLine();
                if (strInput.ToLower() == "circle")
                {
                    Circle circle1 = new Circle();
                    circle1.PrintAreaOrDimension();
                }
                else if (strInput.ToLower() == "square")
                {
                    Square square1 = new Square();
                    square1.PrintAreaOrDimension();
                }
                else if (strInput.ToLower() == "quit")
                {
                    Console.WriteLine("Bye Bye");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
        }
    }
}

