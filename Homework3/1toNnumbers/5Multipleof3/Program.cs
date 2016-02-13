using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Multipleof3
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 1; true; i++)
            {
                int n = 0;
                string x;
                Console.Write("Please enter a number. (enter Q to exit) :");
                x = Console.ReadLine();

                if (x == "Q")
                {
                    Console.Write("Thank You. Bye Bye!");
                    break;
                }
                else

                {
                    n = Convert.ToInt32(x);


                    if ((n % 30 == 0))
                    {

                        Console.WriteLine(n + "  is a multiple of 3,15 and 30");

                    }

                    else if (n % 3 == 0 && n % 15 == 0)
                    {

                        Console.WriteLine(n + "  is a multiple of 3 and 15");
                    }
                    else if ((n % 3 == 0))
                    {

                        Console.WriteLine(n + "  is a multiple of 3");
                    }
                    else
                    {
                        Console.WriteLine(n + "  is not a multiple of 3,15 and 30");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
