using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the type of input (Number / Text / Quit): ");
                string strInput = Console.ReadLine();
                if (strInput.ToLower() == "number")
                {
                    Arithmetic arithmetic1 = new Arithmetic();
                    arithmetic1.PrintSquareOrSquareRootOrIsPrime();
                }
                else if (strInput.ToLower() == "text")
                {
                    TextHelper textHelper1 = new TextHelper();
                    textHelper1.PrintCharOrVowel();
                }
                else if (strInput.ToLower() == "quit")
                {
                    Console.WriteLine("Bye Bye.");
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
