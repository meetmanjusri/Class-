using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Acceptanystring
{
    class Program
    {
        static void Main(string[] args)
        {

            bool decision;
            string result = "";
            do
            {
                Console.Write("Please enter your input :");
                var input = Convert.ToString(Console.ReadLine());
                Console.Write("Do you want to continue Y/N ? ");
                decision = Console.ReadLine().ToUpper() == "Y";
                result += input;
                result = result + "\n";
            } while (decision);
            Console.WriteLine(result);
            Console.WriteLine("Thank you. Bye Bye!");
           
        }
    }
}
