using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solution_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {

                Console.Write("\nPlease enter an action (Login / Logoff / Quit) : ");

                string strInput = Console.ReadLine();
                {
                    if (strInput == "login")
                    {
                        Console.Write(LoginService.Login);
                    }
                    else if (strInput == "logoff")
                    {
                        Console.Write(LoginService.Logoff);
                    }

                    else if (strInput == "quit")
                    {
                        Console.Write(LoginService.Quit);
                    }
                }
                
                    count = count + 1;
                

                if (strInput == "logoff")
                    break;
            }

            Console.WriteLine("Thank you! A total of" + count + "users logged in and logged off.", true);
            
        }
    }
    
}
