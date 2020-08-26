/// <summary>
/// Created By Madhumitha
/// </summary>

using static System.Console;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.BusinessLogicLayer;
using System;
    namespace FlightBooking
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("enter bookingId:");
                int bookingId = int.Parse(Console.ReadLine());

                Console.Write("enter date:");
                int date = int.Parse(Console.ReadLine());

                Console.Write("enter seatNumber:");
            int seatNumber = Console.ReadLine();

                //Random class generates pseudo Randon numbers
                var random = new Random();
                int RandomNo = random.Next();
                int SeatNumber = RandomNo;


                Console.WriteLine("================== TICKET CANCELLATION==========================");
                Console.WriteLine(" Bookingid:" + bookingId);
                Console.WriteLine(" date:" + date);
                Console.WriteLine(" seatNumber :" + seatNumber);
                Console.WriteLine(" you are alloted in seat number: " + SeatNumber);
                Console.WriteLine("============================================================");

                Console.WriteLine(" bookingId   date SeatNumber");
                Console.WriteLine("-----------------------------------------------------");


                static void TicketCancellationMenu()
                {
                    int choice = 1;
                    do
                    {
                        Console.WriteLine("========TICKETCANCELLATION MENU=========");
                        Console.WriteLine("1. Add TicketCancellation");
                    Console.WriteLine("2. Update TicketCancellation");
                        Console.WriteLine("3. View TicketCancellation");
                        Console.WriteLine("4. Delete TicketCancellation");
                        Console.WriteLine("5. exit");
                        Console.Write("Enter choice: ");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1: AddNewTicketCancellation(); break;
                            case 2: ViewTicketCancellation(); break;
                            case 3: UpdateTicketCancellation(); break;
                            case 4: DeleteTicketCancellation(); break;

                        }

                    } while (choice != 5);
                }

                 public static void AddNewTicketCancellation()
                {

                    //create another list in the collection called  "flightbooking1"
                    List<TicketCancellation> flightBooking1 = new List<TicketCancellation>() {
                 new TicketCancellation() { BookingId ="1234",seatNumber = "01", time = "2020-08-29 7:30:00 AM"},
                 new TicketCancellation() { BookingId ="1234",seatNumber = "01", time = "2020-08-29 7:30:00 AM"},
                 new TicketCancellation() { bookingId ="1234",SeatNumber = "01", Time = "2020-08-29 7:30:00 AM"},
                 new TicketCancellation() { bookingId ="1234",SeatNumber = "01", Time = "2020-08-29 7:30:00 AM"},
                 };

                    // add all the elements of "flightSchedule1" collection at the end of "flightschedule" colletion
                    TicketCancellation.AddRange(Ticket Cancellation);

                    //get values from list collection
                    foreach (TicketCancellation item in TicketCancellation)
                    {
                        Console.WriteLine(item);


                    }
                    Console.ReadKey();
                }

                static void ViewTicketCancellation()
                {

                    List < TicketCancellation tc = TicketCancellationbusinessLogicLayer.GetTicketCancellation();
                TicketCancellation ticketCancellation = new TicketCancellation();

                    foreach (TicketCancellation item in tc)
                    {
                    Console.WriteLine(+tc.bookingId + ",", +tc.seatNmuber + ",", tc.date + ",");

                    }
                }

            }
        }









            /*{
                Console.WriteLine("===TICKET CANCELLATION MENU===");
                Console.WriteLine("1. Add Booking ID");
                Console.WriteLine("2. view Date");
                Console.WriteLine("4. cancel or replace");
                Console.WriteLine("3. update Date");
                {

                    switch (choice = 1)
                    {

                        case 1:
                            Console.WriteLine("Enter  Booking Id: ");
                            tc.bookingId = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter date: ");
                            tc.seatNumber = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter  cancel or replace Date: ");
                            tc.date = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter  updated date: ");
                            tc.date = Console.ReadLine();
                            break;
                        default:
                            System.Console.WriteLine("cancellation  bookingid");
                            tc.bookingid = Console.ReadLine();
                            break;*/































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


