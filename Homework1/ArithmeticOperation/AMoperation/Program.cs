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
            float x, y, result;
            Char option;
            Console.Write("Enter the first number: ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the second number: ");
            y = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform : ");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case '1':
                    result = x + y;
                    Console.WriteLine("The result of Addition is : {0}", result);
                    break;
                case '2':
                    result = x - y;
                    Console.WriteLine("The result of Subtraction is : {0}", result);
                    break;
                case '3':
                    result = x * y;
                    Console.WriteLine("The result of Multiplication is : {0}", result);
                    break;
                case '4':
                    result = x / y;
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
