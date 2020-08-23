/// <summary>
/// Created By Madhumitha
/// </summary>

using static System.Console;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.BusinessLogicLayer;
using System;

namespace Znalytics.Group5.Airline.PresentationLayer
{
    /// <summary>
    /// This Class Represents Presentation Layer Of Price
    /// </summary>
    class TicketCancellationPresentation
    {
        /// <summary>
        /// Main Method
        /// </summary>
        static void Main()
        {
            TicketCancellationPresentationMenu();//Calling Menu Method For List Of Menus
            ReadKey();
        }

        private static void TicketCancellationPresentationMenu()
        {
            throw new NotImplementedException();
        }
        static void TicketCancellation()
        {
            int choice = 0;
            do
            {
                WriteLine("===TICKET CANCELLATION MENU===");
                WriteLine("1. Add Booking ID");
                WriteLine("2. Delete Booking ID");
                WriteLine("3. Update Booking ID");
                WriteLine("4. View Booking ID");
                WriteLine("5. Add seatnumber");
                WriteLine("6. View seatnumber");
                WriteLine("7. cancel");
                Write("Enter Your choice: ");
                choice = int.Parse(ReadLine());

                switch (choice)
                {
                    case 1: AddbookingID(); break;
                    case 2: ViewBookingId(); break;
                    case 3: AddseatNumber(); break;
                    case 4: viewseatNumber(); break;
                    case 5: Cancel(); break;


                }
            } while (choice != 6);
        }

        /// <summary>
        /// This Method Represents AddPrice to Add price of Flight
        /// </summary>

        public static void AddbookingID()
        {
            TicketCancellationBusinessLogic TicketCancellationBusinessLogic = new TicketCancellationBusinessLogic();
            TicketCancellation TicketCancellation = new TicketCancellation()

            Write("Enter Booking id: ");
            TicketCancellation.bookingID = int.Parse(ReadLine());

            TicketcancellationBusinessLogic.AddBookingId(TicketCancellation);
            WriteLine("The Details of booking is Successfully Added \n");
        }

    }
  public static void viewbookingID()
    {
        TicketCancellationBusinessLogic TicketCancellationBusinessLogic = new TicketCancellationBusinessLogic();
        TicketCancellation TicketCancellation = new TicketCancellation()

            Write("View Booking id: ");
        TicketCancellation.bookingID = int.Parse(ReadLine());

        TicketcancellationBusinessLogic.AddBookingId(TicketCancellation);
        WriteLine("view is successfull \n");
    }
    private static void AddseatNumber()
    {
        TicketCancellationBusinessLogic TicketCancellationBusinessLogic = new TicketCancellationBusinessLogic();
        TicketCancellation TicketCancellation = new TicketCancellation()

            Write("View seat number: ");
        TicketCancellation.seatNumber = int.Parse(ReadLine());

        TicketcancellationBusinessLogic.AddBookingId(TicketCancellation);
        WriteLine("booking id added succesfull \n");
    }
    private static void viewseatNumber()
    {
        throw new NotImplementedException();
    }
    private static void Cancel()
    {
        throw new NotImplementedException();
    }




































/*//created by Madhumitha
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.BusinessLogicLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Airline
{
    public class Program
    {
        static void Main()
        {
            TicketCancellationPresentation();
            Console.ReadKey();
        }

        static void FlightCancellationPresentation()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("=======FLIGHT DETAILS=====");
                Console.WriteLine("1. Add FlightNames");
                Console.WriteLine("2. View FlightNames");
                Console.WriteLine("3. Update FlightNames");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddFlightNames(); break;
                    case 2: ViewFlightNames(); break;
                    case 3: UpdateFlightNames(); break;
                }
            } while (choice != 4);

        static void AddFlightName()
        {
            FlightcancellationBusinessLogic = new FlightCancellationBusinessLogic();
            FlightCancellation FlightCancellation = new FlightCancellation();

            Console.Write("Enter FlightId: ");
            FlightCancellation.FlightId = int.Parse(Console.ReadLine());
            Console.Write("Enter FlightName");
            FlightCancellation.FlightName = Console.ReadLine();

            flightcancellationBusinessLogic.Add(FlightName);
            Console.WriteLine("FlightName Added.\n");
        }

        static void ViewFlightName()
        {
           FlightCancellationBusinessLogic FlightCancellationLogic = new FlightCancellationBusinessLogic();
            List<FlightCancellation> fli = flightcancellationBusinessLogic.GetEmployees();

            foreach (FlightName Flight in fli)
            {
                Console.WriteLine(fli.flightID + ", " + fli.FlightName);
            }
        }

        static void UpdateFlightName()
        {
            FlightCancellationBusinessLogic FlightCancellationBusinessLogic = new FlightCancellationBusinessLogic();
            FlightName flight = new Flight();

            Console.Write("Enter Existing Fli ID: ");
            FlightCancellation.FlightID = int.Parse(Console.ReadLine());
            Console.Write("Enter New Fli Name: ");
            Flight.FlightName = Console.ReadLine();

            FlightCancellationBusinessLogic.UpdateFlightName(flight);
            Console.WriteLine("FlightName Updated.\n");
        }
    }
}


/*class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter flight name");
        string FlightName = System.Console.ReadLine();
        System.Console.WriteLine("Enter Date:");
        string Date = System.Console.ReadLine();
        System.Console.WriteLine("Enter Time");
        string Dime = System.Console.ReadLine();
        System.Console.WriteLine("cancellation");
        string Cancel = System.Console.ReadLine();


        System.Console.WriteLine("flightname"); //get method will be called
        System.Console.WriteLine("Date"); //get method will be called
        System.Console.WriteLine("Time"); //get method will be called 
        System.Console.WriteLine("Cancel"); //get method will be called

        Flight.fli = "flight name"; //set method will be called
        f.Date = "Date";//set method will be called
        f.time = "Time";//set method will be called
        f.cancel = "Cancel";

        System.Console.ReadKey();
    }
}*/


