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
            Console.Write("\nEnter Starting Number: ");
            int StartingNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Ending Number: ");
            int EndingNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nFibonacci series is : ");
            if (StartingNumber == 0)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            if (StartingNumber == 1)
            {                
                Console.WriteLine(y);
            }

            for (int i = 0; i < EndingNumber; i++)
            {
                z = x + y;
                x = y;
                y = z;

                if (z > EndingNumber)
                {
                    break;
                }

                if (z >= StartingNumber)
                {
                    Console.WriteLine(z);
                }

                //if (z >= StartingNumber && z <= EndingNumber)
                //{
                //    Console.WriteLine(z);
                //}
            }
        }
    }
}

