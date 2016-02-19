using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PalindromeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a string (Q:Exit): ");
                string inputname = Console.ReadLine();

                if (inputname != null && inputname != "Q")
                {
                    string strToUpper = inputname.ToUpper();
                    char[] toReverse = strToUpper.ToCharArray();
                    Array.Reverse(toReverse);
                    String strReverse = new String(toReverse);
                    if (strToUpper == strReverse)
                    {
                        Console.WriteLine(inputname + " is a palindrome");
                    }

                    else
                    {
                        Console.WriteLine(inputname + " is not a palindrome");
                    }
                }
                if (inputname == "Q")
                {
                    Console.WriteLine("Thank you Bye Bye");
                    break;
                }
            }
        }
    }
}
   
  

