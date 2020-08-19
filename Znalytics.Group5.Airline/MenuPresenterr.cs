using System;
using System.Collections.Generic;

namespace Znalytics.Group5.Airline
{
    class MenuPresenterr
    {
        public class MenuPresenter
        {
            public static void Menu()
            {
                int choice = -1;

                do
                {
                    Console.WriteLine("MENU ::");
                    Console.WriteLine("1. Flights");
                    Console.WriteLine("2. Exit");

                    bool b = int.TryParse(Console.ReadLine(), out choice);
                    if (b == true)
                    {
                        switch (choice)
                        {
                            case 1: FlightsMenu(); break;

                        }
                    }
                } while (choice != 2);
            }

            private static void FlightsMenu()
            {
                int choice = -1;
                do
                {
                    Console.WriteLine("Flights Menu:");
                    Console.WriteLine("1. Add Flight");
                    Console.WriteLine("2. Update Flight");
                    Console.WriteLine("3. Exit");

                    bool b = int.TryParse(Console.ReadLine(), out choice);
                    if (b == true)
                    {
                        switch (choice)
                        {
                            case 1: AddFlight(); break;

                        }
                    }
                } while (choice != 9);
            }

            private static void AddFlight()
            {
                Flight flight = new Flight();
                Console.Write("Enter flight name to be added: ");
                string userinput = Console.ReadLine();
                if (userinput != "null")
                {
                    flight.Add(userinput);
                    foreach (object obj in flight)
                        Console.Write(obj.ToString() + " ");
                }
                else
                {
                    Console.Write("not allowed");
                }

            }
        }


    }
}
}
