using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.BussinessLogicLayer;
using Znalytic.Group5.Airline.Entities;

//Represents Presentation Layer

namespace Znalytic.Group5.Airline.PresentationLayer
{
   
       class FlightDetailSchedule
        {
           
            static void Main()
            {
                        // Enter the details of Flight
                         System.Console.Write("Enter FlightName:"); //Name of the Flight
                         string flightName = Console.ReadLine();

                        System.Console.Write("Enter FlightId:"); // enter flight id
                         int flightId = int.Parse(Console.ReadLine());

                        System.Console.Write("Enter source:"); // Enter "FROM" Address
                        String  source = Console.ReadLine();

                        System.Console.Write("Enter destination:"); //enter "To" Addrress
                        string  destination = Console.ReadLine();

                        //DateTime used to represent date and time of the Day

                        System.Console.WriteLine("enter Departure Timing:"); //
                        var userDate = Console.ReadLine();
                        System.DateTime UserDateTime;  //  DateTime is of type DateTime Datatype
                        if (System.DateTime.TryParse(Console.ReadLine(), out UserDateTime))
                        {
                            Console.WriteLine("the day of the week is:" + UserDateTime.DayOfWeek);
                        }
                        else
                        {
                            Console.WriteLine("you have entered an incorrect value:");
                        }
                        Console.ReadLine();
                        string departureTiming = Console.ReadLine();

                        System.Console.WriteLine("enter Arrival Timing:");
                        var inputtedDate = Console.ReadLine();
                        System.DateTime result;
                        System.DateTime.TryParse(inputtedDate, out result);
                        string  arrivalTiming= Console.ReadLine();


                      // Display the Flight Details

                        System.Console.WriteLine("---------------FLIGHT SCHEDULE---------------------------------------------");

                        System.Console.WriteLine("flightName:" + flightName);
                        System.Console.WriteLine("flightId:" + flightId);
                        System.Console.WriteLine("source:" + source);
                        System.Console.WriteLine("destination:" + destination);
                        System.Console.WriteLine("departureTiming:" + departureTiming);
                        System.Console.WriteLine("arrivalTiming:" + arrivalTiming);

                        System.Console.WriteLine("--------------------------------------------------------------------------------------------");

                        System.Console.WriteLine("--------------------SCHEDULE LIST------------------------------------------------------------");
                        System.Console.WriteLine("flightName    flightId      source       destination     departureTiming       arrivalTiming");


                        System.Console.WriteLine("----------------------------------------------------------------------------------------------");


                         FlightDetailsMenu();
                         Console.ReadKey();
            }

         static void FlightDetailsMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("========FLIGHT MENU=========");
                Console.WriteLine("1. Add FlightDetail");
                Console.WriteLine("2. View FlightDetails");
                Console.WriteLine("3. Update FlightDetail");
                Console.WriteLine("4. Search FlightDetails");
                Console.WriteLine("5. Delete FlightDetail");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddFlightDetail(); break;
                    case 2: ViewFlightDetails(); break;
                    case 3: UpdateFlightDetails(); break;
                    case 4: SearchFlightDetails(); break;
                    case 5: DeleteFlightDetail(); break;

                }

            } while (choice != 6);
        }

        static void AddFlightDetail()
        {
           FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();
            FlightDetail flight = new FlightDetail();

            Console.Write("Enter flight ID: ");
            flight.flightId = int.Parse(Console.ReadLine());
            Console.Write("Enter flight Name: ");
            flight.flightName = Console.ReadLine();

            flightBusinessLogic.Add(flight);
            Console.WriteLine("flight is Added.\n");
        }


        static void ViewFlightDetails()
        {
            FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();
            List<FlightDetail> f = flightBusinessLogic.GetFlightDetail();

            foreach(FlightDetail flight in f)
            {
                Console.WriteLine(flight.flightId + ", " + flight.flightName);
            }
        }


        static void UpdateFlightDetails()
        {
            FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();
           FlightDetail flight = new FlightDetail();

            Console.Write("Enter Existing flight Id : ");
            flight.flightId = int.Parse(Console.ReadLine());
            Console.Write("Enter New flight Name: ");
             flight.flightName = Console.ReadLine();

            flightBusinessLogic.UpdateFlightDetails(flight);
            Console.WriteLine("flight is  Updated.\n");
        }

        static void SearchFlightDetails()
        {
            FlightDetail flight = new FlightDetail();
            Console.WriteLine("enter flightname you wish to search:");
            string flightName = Console.ReadLine();
            if (flight.contains(flightName))
            Console.WriteLine("success,flight" + flightName);

        }


        static void DeleteFlightDetail()
        {
            FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();
            FlightDetail flight = new FlightDetail();
            Console.WriteLine("enter the flightName you wish to delete:");
            string flightName = Console.ReadLine();
            flight.Remove(flightName);
            flightBusinessLogic.DeleteFlightDetails(flight);
            Console.WriteLine("flight deleted succcessfully.\n");
        }

      
     




    }


}
        