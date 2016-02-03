using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the pattern:");
            var c = Convert.ToString(Console.ReadLine());

            if(c == "Odd")
                Console.WriteLine("Odd");
            else
                Console.WriteLine("Even");
        }
    }
}
