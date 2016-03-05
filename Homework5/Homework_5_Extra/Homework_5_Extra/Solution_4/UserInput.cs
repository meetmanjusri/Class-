using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class UserInput
    {
        public static double AcceptNumberInput()
        {
            double numInput = 10;
            while (true)
            {
                string strInput = Console.ReadLine();
                var isSuccess = double.TryParse(strInput, out numInput);
                if (isSuccess)
                    break;
                else
                {
                    Console.Write("Value entered is not a number. Please retry again: ");
                }
            }
            return numInput;
        }
    }
}
