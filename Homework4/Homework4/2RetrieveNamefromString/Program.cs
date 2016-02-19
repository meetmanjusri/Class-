using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2RetrieveNamefromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleString;
            string inputname = "";
            //Console.Write("What is your name? : " + "My name is ");
            //inputname = Console.ReadLine();
            //sampleString = inputname.Substring(0,inputname.Length);
            //Console.WriteLine("Hi " + sampleString + "." + "How are you doing today?");

            Console.Write("What is Your name? : ");
            inputname = Console.ReadLine();
            sampleString = inputname.Substring(11, inputname.Length - 11);
            Console.WriteLine("Hi " + sampleString + "." + "How are you doing today?");
           
        }
    }
}