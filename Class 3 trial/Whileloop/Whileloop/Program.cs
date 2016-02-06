using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int result =0;
            string x="Y";
            while (x.ToUpper() == "Y")
            {
                Console.Write("Enter a number:");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Do you want to continue (Y/N) ?");
                x = Console.ReadLine();
                result = result + n;

            }
            Console.WriteLine("Total sum:" + result);
            
        }
    }
}
