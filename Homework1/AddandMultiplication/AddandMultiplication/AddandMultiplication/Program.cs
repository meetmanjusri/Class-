using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddandMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int inputnum;
            string Add, Multiply;
            if (result == 0)
            {
                Console.WriteLine("Operation :" + Add);
                Console.ReadLine();
            }
            for (int i = 0; i < inputnum; i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                inputnum = Convert.ToInt32(Console.ReadLine());
                result = result + inputnum;
            }

            Console.WriteLine(result);
        }
            if (result == 1)
            {
                Console.WriteLine("Operation :" + Multiply);
                Console.Readline();
            }
                for (int i = 0; i < inputnum; i++)
                {
                    Console.WriteLine("Enter number " + (i + 1));
                    inputnum = Convert.ToInt32(Console.ReadLine());
                    result = result * inputnum;
                }
                Console.WriteLine(result);
           }
          
        }
    }

