using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

       //// presentation

using System;
using System.Collections.Generic;

namespace  FlightBooking
    {
    class FlightBooking
    {
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
                    Console.WriteLine("3. View FlightBooking");
                    Console.WriteLine("4. Delete FlightBooking");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter choice: ");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: AddNewFlightBooking(); break;
                        case 2: ViewFlightBooking(); break;
                        case 3: UpdateFlightBooking(); break;
                        case 4: DeleteFlightBooking(); break;

                    }

                } while (choice != 5);
            }

            static void AddNewFlightBooking()
            {

                //create another list in the collection called  "flightbooking1"
                List<FlightBooking> flightBooking1 = new List<FlightBooking>() {
                    new FlightBooking() { flightName = "AirInia", flightNumber = "101", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = "01", bookingId = "1234" },
                    new FlightBooking() { flightName = "AirIndia", flightNumber = "101", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am", seatNumber = "02", bookingId = "1234" },
                    new FlightBooking() { flightName = "AirIndia", flightNumber = "101", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = "03", bookingId = "3456" },
                    new FlightBooking() { flightName = "AirIndia", flightNumber = "101", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = "04", bookingId = "7891" },
                    new FlightBooking() { flightName = "AirIndia", flightNumber = "101", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am", SeatNumber = "05", bookingId = "6789" } };



                static void ViewFlightBooking()
                {

                    List<FlightBooking> fb = FlightBookingbusinessLogic.GetFlightBooking();
                    FlightBooking fb = new FlightBooking();

                    foreach (FlightBooking item in fb)
                    {
                        Console.WriteLine(fb.flightName + "," + fb.flightNumber + "," + fb.source + "," + fb.destination + "," + fb.arrivalTiming + "," + fb +.departureTiming + "," + fb.seatNmuber + "," + fb.bookingId + ",");

                    }
                }
                static void updateFlightBooking()
                {

                    List<FlightBooking> fb = FlightBookingbusinessLogic.GetFlightBooking();
                    FlightBooking fb = new FlightBooking();

                    foreach (FlightBooking item in fb)
                    {
                        Console.WriteLine(fb.flightName + "," + fb.flightNumber + "," + fb.source + "," + fb.destination + "," + fb.arrivalTiming + "," + fb.departureTiming + "," + fb.seatNmuber + "," + fb.bookingId + ",");

                    }
                }

                static void DeleteFlightBooking()
                {

                    List<FlightBooking> fb = FlightBookingbusinessLogic.GetFlightBooking();
                    FlightBooking fb = new FlightBooking();

                    foreach (FlightBooking item in fb)
                    {
                        Console.WriteLine(fb.flightName + "," + fb.flightNumber + "," + fb.source + "," + fb.destination + "," + fb.arrivalTiming + "," + fb.departureTiming + "," + fb.seatNmuber + "," + fb.bookingId + ",");

                    }
                }
            }
        }
    }
    