using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the type of vehicle (Bike / Car / Train / Plane / Quit) : ");
                string strInput = Console.ReadLine();
                if (strInput.ToLower() == "bike")
                    Console.WriteLine(Bike.show);
                else if (strInput.ToLower() == "car")
                    Console.WriteLine(Car.show);
                else if (strInput.ToLower() == "train")
                    Console.WriteLine(Train.show);
                else if (strInput.ToLower() == "plane")
                    Console.WriteLine(Plane.show);
                else if (strInput.ToLower() == "quit")
                {
                    Console.WriteLine("Bye Bye");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option.");
                }
            }
        }
    }
}
