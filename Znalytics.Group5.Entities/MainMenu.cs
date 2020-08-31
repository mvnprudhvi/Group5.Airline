using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytic.Group5.Airline.PresentationLayer;

namespace Znalytics.Group5.Entities
{
    class MainMenu
    {
        static void Main()
        {
            int choice = 0;
            do
            {        
             Console.WriteLine("******** WELCOME TO ONLINE AIRLINE RESERVATION SYSTEM***********");
             Console.WriteLine("\n1.AdminMenu");
             Console.WriteLine("\n2.CustomerMenu");
             Console.WriteLine("\n3.Exit");
             bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {

                   switch (choice)
                    {
                     case 1:    //Creating object to FlightPresentationLayer
                             FlightPresentation Fp = new FlightPresentation();
                             Fp.start();
                             break;
                      case 2: CustomerMenu(); break;
                    }

                }
            } while (choice <= 3);
            
        }
        public static void CustomerMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine(" ====CUSTOMERSMENU==== ");
                Console.WriteLine("1.CustomersPage");
                Console.WriteLine("2.FlightSearchingMenu");
                Console.WriteLine("3.FlightBookingMenu");
                Console.WriteLine("4.FlightsPriceMenu");
                Console.WriteLine("5.TicketCancellationMenu");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {

                    switch (choice)
                    {
                        case 1:    //Creating object to FlightPresentationLayer
                            CustomerPL cp = new CustomerPL();
                            cp.start();
                            break;
                        case 2: CustomerMenu(); break;
                    }

                }
            }
        /*
        //Menu For Choosing Options
        System.Console.WriteLine("\n1 - AdminMenu ");
                System.Console.WriteLine("\n2 - CustomerMenu");
                System.Console.WriteLine("\n3 - TRANSACTIONS");
                System.Console.WriteLine("\n4 - LOANS");
                System.Console.WriteLine("\n4 - CREDIT CARD");

                Console.Write("\nEnter Your choice : ");

                ch = System.Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        //Creating object to CustomerPresentationLayer
                        CustomerPresentationLayer p = new CustomerPresentationLayer();
                        p.start();
                        break;
                    case "2":

                        break;
                    case "3":
                        //Calling method
                        TransactionMenu.start();

                        break;
                    case "4":
                        PersonalVehicleLoanPresentationLayer pv = new PersonalVehicleLoanPresentationLayer();
                        pv.start();
                        break;
                    case "5":
                        //Creating object to CreditcardPresentationLayer
                        CreditcardPresentationLayer cr = new CreditcardPresentationLayer();
                        cr.start();
                        break;
                    default:
                        Console.WriteLine("\nOoops......You have Choosen Wrong Option\n");
                        break;

                }
                Console.Write("\n Do you want to Use PECUNIA BANK Again press Y : ");
                ch = Console.ReadLine();

            } while (ch == "Y" || ch == "y");
            Console.ReadKey();
        }
    }

}
}
