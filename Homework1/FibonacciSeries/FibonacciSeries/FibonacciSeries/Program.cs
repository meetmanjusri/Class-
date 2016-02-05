using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int z;
            Console.WriteLine("Enter Starting Number: ");
            int StartingNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Number: ");
            int EndingNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series is : ");
            if (StartingNumber == 0)
                {
                Console.WriteLine(x);
            }
            if (StartingNumber == 1)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(StartingNumber);
            }

            for (int i = StartingNumber; i < EndingNumber; i++)
            {
                z = x + y;
                x = y;
                y = z;
                if (z>= StartingNumber && z > EndingNumber)
                {
                    break;
                }
               
                Console.WriteLine(z);
            }

        }
    }
}

