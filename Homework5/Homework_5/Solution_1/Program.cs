using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter an option : Circle / Square / Rectangle / Triangle / Quit : ");
                string strInput = Console.ReadLine();
                if (strInput.ToLower() == "circle")
                {
                    Circle circle1 = new Circle();
                    circle1.PrintArea();
                }
                else if (strInput.ToLower() == "square")
                {
                    Square square1 = new Square();
                    square1.PrintArea();
                }
                else if (strInput.ToLower() == "rectangle")
                {
                    Rectangle rectangle1 = new Rectangle();
                    rectangle1.PrintArea();
                }
                else if (strInput.ToLower() == "triangle")
                {
                    Triangle triangle1 = new Triangle();
                    triangle1.PrintArea();
                }
                else if (strInput.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please select a valid option.");
                }
            }
        }
    }
}
