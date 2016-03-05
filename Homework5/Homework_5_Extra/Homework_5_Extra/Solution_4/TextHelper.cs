using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class TextHelper
    {
        public string strInput, strInput1;
        public int count;
        public TextHelper()
        {
            Console.Write("Please enter some text: ");
            strInput = Console.ReadLine();
            Console.Write("Please enter what you want to count (Char/Vowel): ");
            strInput1 = Console.ReadLine();
        }
        public void PrintCharOrVowel()
        {
            if (strInput1.ToLower() == "char")
            {
                count = strInput.Length;
                Console.WriteLine("The number of characters in " + strInput + " is " + count);
            }
            else if (strInput1.ToLower() == "vowel")
            {
                for (int i = 0; i < strInput.Length; i++)
                {
                    if (strInput[i] == 'a' || strInput[i] == 'e' || strInput[i] == 'i'  || strInput[i] == 'o' || strInput[i] == 'u')
                    {
                        count++;
                    }
                }
                Console.WriteLine("The number of vowels in " + strInput + " is " + count);
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
}
