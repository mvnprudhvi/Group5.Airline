using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.Airline
{
    class OnlineAirlineReservationPL
    {
        static void Main()
        {
            Console.WriteLine("============ONLINE AIRLINE RESERVATION SYSTEM=============");
            MainMenu();
            Console.ReadKey();
        }

        static void MainMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("//MAINMENU//////");
                Console.WriteLine("1.AdminMenu");
                Console.WriteLine("2.CustomerMenu");
                Console.WriteLine("EXIT");
                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AdminLogin(); break;
                        case 2: CustomerLogin(); break;
                    }
                }
            } while (choice != 4);
        }
        static void AdminLogin()
        {
            Console.Write("\nuserName:");
            string userName = Console.ReadLine();
            System.Console.Write("Password:");
            string password = Console.ReadLine();

            if (userName == "Admin" && password == "manager")
            {
                AdminMenu();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("username and password doesn't match ,,Try again");
            }
        }

        }

        }
        
    }

