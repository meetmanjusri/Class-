using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3usinganyloop
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            string x;

            while (true)
            {
                int i = 1;
                Console.Write("\nPlease enter a number. Enter Q to exit :");

                x = Console.ReadLine();

                if (x == "Q")
                {
                    Console.Write("Thank You. Bye Bye!");
                    break;
                }

                n = Convert.ToInt32(x);

                while (i <= n)
                {
                    Console.Write(i++);
                    if (i < n+1)
                        Console.Write(",");
                    if (i == n+1)
                        Console.Write(".");
                }


            }

        }
    }
}
