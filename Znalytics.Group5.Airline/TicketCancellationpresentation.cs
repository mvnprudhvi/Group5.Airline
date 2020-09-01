//created by Madhumitha.......
using System.Collections.Generic;
using Znalytic.Group5.BussinessLogicLayer;
using Znalytics.Group5.Airline.Entities;
using System;
/// <summary>
/// </summary>
namespace Znalytics.Group5.Airline.PresentationLayer
{
    /// <summary>
    /// This Class Represents Presentation layer of ticket cancellation
    /// </summary>
    class TicketCancellationPresentation
    {
       
        private static TicketCancellationBusinessLogicLayer _ticketCancellationBusinessLogicLayer;     
        private static IEnumerable<TicketCancellation> _ticketCancellation;

        /// <summary>
        /// Main Method
        /// </summary>
        static void Main()
        {
            _ticketCancellationBusinessLogicLayer = new TicketCancellationBusinessLogicLayer();
            //Calling Menu Method For List Of Menus
            TicketCancellationMenu();
            Console.ReadKey();
        }

        /// <summary> 
        /// This Method Represents Ticket cancellation Menu To View Operations Of Price
        /// </summary>
        static void TicketCancellationMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine(" ================== TICKET CANCELLATION ========================== ");
                Console.WriteLine("1. Add Ticket Cancellation");
                Console.WriteLine("2. Delete Ticket Cancellation");
                Console.WriteLine("3. Update  Ticket Cancellation");
                Console.WriteLine("4. View Ticket Cancellation ");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your choice: ");
                choice = int.Parse(ReadLine());
                //represents switch case
                switch (choice)
                {
                    case 1: AddTicketCancellation(); break;
                    case 2: DeleteTicketCancellation(); break;
                    case 3: UpdateTicketCancellation(); break;
                    case 4: GetTicketCancellation(); break;
                }
            } while (choice != 5);
        }

        private static string ReadLine()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This Method Represents add ticket cancellation
        /// </summary>
        static void AddTicketCancellation()
        {
            TicketCancellation tc = new TicketCancellation();

            Console.Write("Enter booking id: ");
            tc.BookingID = int.Parse(ReadLine());

           Console .Write("Enter customer id ");
            tc.CustomerID = int.Parse(ReadLine());

            _ticketCancellationBusinessLogicLayer.AddTicketCancellations(tc);

            Console.WriteLine("The details of ticket cancellation  is Successfully Added \n");
        }

        /// <summary>
        /// This Method Represents Delete ticket cancellation by booking
        /// </summary>
        static void DeleteTicketCancellation()
        {

            TicketCancellation tc = new TicketCancellation();
            Console.Write("Enter Existing booking id to Delete ticket cancellation ");
            _ticketCancellationBusinessLogicLayer.DeleteTicketCancellation(tc);
            Console.WriteLine("The ticket cancellation is Deleted Successfully \n");
        }

        /// <summary>
        /// This Method Represents Update ticket cancellation
        /// </summary>
        static void UpdateTicketCancellation()
        {

            TicketCancellation tc = new TicketCancellation();

            Console.Write("Enter Existing booking id: ");
            tc.BookingID = int.Parse(ReadLine());

            Console.Write("Enter existing customer id");
            tc.CustomerID = int.Parse(ReadLine());

            _ticketCancellationBusinessLogicLayer.UpdateTicketCancellations(tc);
            Console.WriteLine("The cancellation of ticket is Updated Successfully \n");
        }

        /// <summary>
        /// This Method Represents get Ticket Cancellation
        /// </summary>
        static void GetTicketCancellation()
        {
            List<TicketCancellation> _tc = _ticketCancellationBusinessLogicLayer.GetTicketCancellations();

            foreach (TicketCancellation tc in _ticketCancellation)
            {
                Console.Write("=====The Ticket Cancellation are Below=====");
                Console.WriteLine("The booking id is " + tc.BookingID);
                Console.WriteLine("The customer id is " + tc.CustomerID);
            }
        }
    }
}


