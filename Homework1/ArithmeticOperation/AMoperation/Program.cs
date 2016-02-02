using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            float result;
            string option;
            Console.Write("Enter Number 1: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operation: ");
            option =Console.ReadLine();
            switch (option)
            {
                case "Add":
                    result = x + y;
                    Console.WriteLine("The result of Addition is : {0}", result);
                    break;
                case "Subtract":
                    result = x - y;
                    Console.WriteLine("The result of Subtraction is : {0}", result);
                    break;
                case "Multiply":
                    result = x * y;
                    Console.WriteLine("The result of Multiplication is : {0}", result);
                    break;
                case "Divide":
                    result = (float)x / y;
                    Console.WriteLine("The result of Division is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
