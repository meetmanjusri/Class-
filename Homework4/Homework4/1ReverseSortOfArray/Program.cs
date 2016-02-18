using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ReverseSortOfArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the length of the Array: ");
            var arraySize = Int32.Parse(Console.ReadLine());
            int[] userArray = new int[arraySize];
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write("Enter the value at index 0:");
                userArray[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(userArray);
            Console.WriteLine("Reverse sorted array:");
            for (int i = userArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userArray[i]);
            }
            Console.ReadLine();
        }
    }
}
