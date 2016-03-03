using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class LoginService
    {
        public string strInput;

        //public LoginService(string name)
       // {
       //     Login = name;
        //    Logoff = name;
       //   Quit = name;
        //}
        public static string Login { get; set; } = "Hi. You are now logged in to the student network. ";
        public static string Logoff { get; set; } = "Hi. You are now logged off to the student network. ";
        public static string Quit { get; set; } = "Sorry you have to logoff before you can Quit. ";

        public void PrintString()
        {
            if (strInput.ToLower() == "login")
                Console.WriteLine(Login);
            else if (strInput.ToLower() == "logoff")
                Console.WriteLine(Logoff);
            else if(strInput.ToLower() == "quit")
                Console.WriteLine(Quit);
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
}
