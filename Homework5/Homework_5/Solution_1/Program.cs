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
                string strToLower = strInput.ToLower();
                if (strInput == "circle")
                {
                    Circle Circle1 = new Circle();
                    Circle1.PrintArea();
                    break;
                }
                else if (strInput == "square")
                {
                    Square Square1 = new Square();
                    Square1.PrintArea();
                    break;
                }
                else if (strInput == "rectangle")
                {
                    Rectangle Rectangle1 = new Rectangle();
                    Rectangle1.PrintArea();
                    break;
                }
                else if (strInput == "triangle")
                {
                    Triangle Triangle1 = new Triangle();
                    Triangle1.PrintArea();
                    break;
                }
                else if(strInput == "quit")
                {
                   
                    break;
                }
                else
                {
                    Console.Write("Please select a valid option.");
                    break;
                }
            }
        }
    }
}
