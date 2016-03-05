using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class Arithmetic
    {
        public double num, square, squareroot, isprime;
        public string strInput;

        public Arithmetic()
        {

            Console.Write("Please enter a number : ");
            num = UserInput.AcceptNumberInput();
            while (true)
            {
                Console.Write("Please enter the type of operation(Square / Root / IsPrime) : ");
                strInput = Console.ReadLine();
                if (strInput.ToLower() == "square" || strInput.ToLower() == "root" || strInput.ToLower() == "isprime")
                    break;
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
        }
        public void PrintSquareOrSquareRootOrIsPrime()
        {
            if (strInput.ToLower() == "square")
            {
                square = num*num;
                Console.WriteLine("The square of " + num +" is "+square);
            }
            else if (strInput.ToLower() == "root")
            {
                squareroot = (double) (Math.Sqrt(num));
                Console.WriteLine("The square root of " + num + " is " + squareroot);
            }
            else if (strInput.ToLower() == "isprime")
            {
                bool prime = IsPrime.Prime(Int32.Parse(num.ToString()));
                if (prime)
                {
                    Console.WriteLine(num + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(num + " is not a prime number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
}
