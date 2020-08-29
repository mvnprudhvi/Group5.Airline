// Created by Reshma
// Presentation Layer
// module: FlightBooking



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

       //// presentation

using System;
using System.Collections.Generic;

namespace Znalytics.Group5.Airline.PresentationLayer
{
    /// <summary>
    /// This Class Represents Presentation Layer Of Price
    /// </summary>
    class FlightBookingPresentation
    {

        private static FlightBookingbusinessLogic  _flightBookingbusinessLogic;
        private static IEnumerable<FlightBookingPresentation> _flightBooking;

        /// <summary>
        /// Main Method
        /// </summary>
        static void Main()
        {
            _flightBookingbusinessLogic = new FlightBookingbusinessLogic();
            //Calling Menu Method For List Of Menus
            FlightBookingMenu();
            Console.ReadKey();
        }

        /// <summary> 
        /// This Method Represents PriceMenu To View Operations Of Price
        /// </summary>
        static void FlightBookingMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine(" ================== FLIGHT BOOKING========================== ");
                Console.WriteLine("1. Add FlightBooking");
                Console.WriteLine("2. Update FlightBooking");
                Console.WriteLine("3. Delete FlightBooking");
                Console.WriteLine("4. Get FlightBooking");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Your choice: ");
                choice = int.Parse(ReadLine());
                //represents switch case
                switch (choice)
                {
                    case 1: AddFlightBooking(); break;
                    case 2: UpdateFlightBooking(); break;
                    case 3: DeleteFlightBooking(); break;
                    case 4: GetFlightBooking(); break;
                }
            } while (choice != 5);
        }

        private static string ReadLine()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This Method Represents adding of flight bookings
        /// </summary>
        static void AddFlightBooking()
        {
            _flightBooking fb= new _flightBooking();

            Console.Write("Enter flight id: ");
           fb.FlightID = int.Parse(ReadLine());

            Console.Write("Enter customer id ");
           fb.CustomerID = int.Parse(ReadLine());

            _flightBookingbusinessLogic.AddFlightBooking(fb);

            Console.WriteLine("The details of FlightBooking is Successfully Added \n");
        }

        

        /// <summary>
        /// This Method Represents Updatation of FlightBooking
        /// </summary>
        static void UpdateFlightBooking()
        {

            _flightBooking fb= new _flightBooking();

            Console.Write("Enter Existing flight id: ");
           fb.flightID = int.Parse(ReadLine());

            Console.Write("Enter existing customer id");
            fb.customerID = int.Parse(ReadLine());

            _flightBookingbusinessLogic.UpdateFlightBooking(fb);
            Console.WriteLine("The booking of Flight is Updated Successfully \n");
        }
        /// <summary>
        /// This Method Represents Delete FlightBooking by booking
        /// </summary>
        static void DeleteFlightBooking()
        {

            _flightBooking fb = new _flightBooking();
            Console.Write("Enter Existing booking id to Delete FlightBooking ");
            _flightBookingbusinessLogic.DeleteFlightBooking(fb);
            Console.WriteLine("The FlightBooking is Deleted Successfully \n");
        }


        /// <summary>
        /// This Method Represents getting all details of  FlightBooking
        /// </summary>
        static void GetFlightBooking()
        {

            object _flightBookingbusinessLayer = null;
            List<FlightBookingPresentation> fb = _flightBookingbusinessLayer.GetFlightBooking();

            foreach (_flightBooking fb in _flightBooking)
            {
                Console.Write("=====The FlightBooking  are Below=====");
                Console.WriteLine("The booking id is " + fb.flightID);
                Console.WriteLine("The customer id is " +fb.customerID);
            }
        }
    }
}

































/*/// <summary>
/// This Class Represents Presentation Layer Of Price
/// </summary>
class FlightBooking
{
    /// <summary>
    /// represents the Main method
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.Write("enter flightName:");
        string flightName = Console.ReadLine();

        Console.Write("enter flight Id:");
        int flightId = int.Parse(Console.ReadLine());

        Console.Write("enter passengerName:");
        string passengerName = Console.ReadLine();
        Console.Write("enter booking id:");
        int bookingId = int.Parse(Console.ReadLine());
        Console.Write("enter seatNumber:");
        //Random class generates pseudo Randon numbers

        var random = new Random();
        int RandomNo = random.Next();
        int SeatNumber = RandomNo;
        int seatNumber = int.Parse(Console.ReadLine());


        Console.WriteLine("================== FlightBooking ==========================");
        Console.WriteLine(" flightName :" + flightName);
        Console.WriteLine(" flightId :" + flightId);
        Console.WriteLine(" passengerName :" + passengerName);
        Console.WriteLine("bookingId:" + bookingId);
        Console.WriteLine(" you are alloted in seat number: " + SeatNumber);

        Console.WriteLine("============================================================");

        Console.WriteLine(" flightName   flightId  passengerName Seat Number bookingId");
        Console.WriteLine("-----------------------------------------------------");


        static void FlightBookingMenu()
        {
            int choice = 1;
            do
            {
                Console.WriteLine("========FLIGHTBOOKING MENU=========");
                Console.WriteLine("1. Add FlightBooking");
                Console.WriteLine("2. Update FlightBooking");
                Console.WriteLine("3. Delete FlightBooking");
                Console.WriteLine("4. Get FlightBookings");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddNewFlightBooking(); break;
                    case 2: UpdateFlightBooking(); break;
                    case 3 :DeleteFlightBooking(); break;
                    case 4: GetFlightBooking(); break;

                }

            } while (choice != 5);
        }

        static void AddNewFlightBooking()
        {

            //create another list in the collection called  "flightbooking1"
            List<FlightBooking> flightBooking1 = new List<FlightBooking>() 
            {
                new FlightBooking() { FlightName = "AirInia", FlightID = 101, Source = "Hyderabad", Destination = "Mumbai", DepartureTiming = 2020-08-29 7:30:00 AM, ArrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = 01, BookingID =1234 },
                new FlightBooking() { FlightName = "AirIndia", FlightID = 101, Source = "Hyderabad", Destination = "Mumbai", DepartureTiming = 2020-08-29 7:30:00 AM, ArrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = 02, BookingID = 1234 },
                new FlightBooking() { FlightName = "AirIndia", FlightID = 101, Source = "Hyderabad", Destination = "Mumbai", DepartureTiming = 2020-08-29 7:30:00 AM, ArrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = 03, BookingID = 3456 },
                new FlightBooking() { FlightName = "AirIndia", FlightID = 101, Source = "Hyderabad", Destination = "Mumbai", DepartureTiming = 2020-08-29 7:30:00 AM, ArrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = 04, BookingID = 7891 },
                new FlightBooking() { FlightName = "AirIndia", FlightID = 101, Source = "Hyderabad", Destination = "Mumbai", DepartureTiming = 2020-08-29 7:30:00 AM, ArrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = 05, BookingID = 6789 } };



            static void ViewFlightBooking()
            {

                List<FlightBooking> fb = FlightBookingbusinessLogic.GetFlightBooking();

                foreach (FlightBooking item in fb)
                {
                    Console.WriteLine(fb.flightName + "," + fb.flightNumber + "," + fb.source + "," + fb.destination + "," + fb.arrivalTiming + "," + fb +.departureTiming + "," + fb.seatNmuber + "," + fb.bookingId + ",");

                }
            }
            static void updateFlightBooking()
            {

                List<FlightBooking> fb = FlightBookingbusinessLogic.GetFlightBooking();

                foreach (FlightBooking item in fb)

                    Console.WriteLine(fb.flightName + "," + fb.flightNumber + "," + fb.source + "," + fb.destination + "," + fb.arrivalTiming + "," + fb.departureTiming + "," + fb.seatNmuber + "," + fb.bookingId + ",");

                }
            }

            static void DeleteFlightBooking()
            {

                List<FlightBooking> fb = FlightBookingbusinessLogic.GetFlightBooking();

                foreach (FlightBooking item in fb)
                {
                    Console.WriteLine(fb.flightName + "," + fb.flightNumber + "," + fb.source + "," + fb.destination + "," + fb.arrivalTiming + "," + fb.departureTiming + "," + fb.seatNmuber + "," + fb.bookingId + ",");

                }
            }
        }

    }
}
}*/
