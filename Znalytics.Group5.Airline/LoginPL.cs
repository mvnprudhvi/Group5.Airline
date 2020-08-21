using System;
using static System.Console;

namespace Znalytics.Group5.AirLine
    {
        class LoginPL
        {
            static void Main()
            {
                //Login
                WriteLine("AIRLINE RESERVATION SYSTEM");
                WriteLine("==================================");
                Write("\nUsername:");
                string userName = ReadLine();
                System.Console.Write("Password:");
                string password = ReadLine();

                if (userName == "," && password == ",")
                {
                 Menu();
                }

                ReadKey();
            }

       
    }
    }
