using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1toNusinganyloop
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1;

            Console.Write("Please enter a number to exit :");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(i);
                i++;                
            } while (i <= n);

            }
            
        }
    }

