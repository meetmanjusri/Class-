using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2usingforloop
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.Write("Please enter a number to exit :");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; true; i++)
            {
               
                Console.Write(i);
                if (i < n)
                    Console.Write(",");
                if (i == n)
                    Console.Write(".");
                if (i == n)
                    break;

            }

        }
    }
}
