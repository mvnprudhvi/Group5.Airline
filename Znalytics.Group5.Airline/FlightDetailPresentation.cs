//......KEERTHANA........

using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.BussinessLogicLayer;
using Znalytics.Group5.Airline.Entities;

//Represents Presentation Layer

namespace Znalytic.Group5.Airline.PresentationLayer
{
   
       class FlightSchedule
        {

        static void Main()
        {
            // Enter the details of Flight


            FlightDetail fd = new FlightDetail();
            FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();

           Console.Write("Enter FlightName:"); //Name of the Flight
            fd.flightName = Console.ReadLine();

           Console.Write("Enter FlightId:"); // enter flight id
            fd.flightId = int.Parse(Console.ReadLine());

           Console.Write("Enter source:"); // Enter "FROM" Address
            fd.source = Console.ReadLine();

           Console.Write("Enter destination:"); //enter "To" Addrress
            fd.destination = Console.ReadLine();

            //DateTime used to represent date and time of the Day

            Console.WriteLine("enter Departure Timing:"); //
            var userDate = Console.ReadLine();
            System.DateTime UserDateTime;  //  DateTime is of type DateTime Datatype
            System.DateTime.TryParse(Console.ReadLine(), out UserDateTime);
            Console.ReadLine();
            fd.departureTiming = Console.ReadLine();

            Console.WriteLine("enter Arrival Timing:");
            var inputtedDate = Console.ReadLine();
            System.DateTime result;
            System.DateTime.TryParse(inputtedDate, out result);
            fd.arrivalTiming = Console.ReadLine();


            // Display the Flight Details


            Console.WriteLine("---------------FLIGHT SCHEDULE---------------------------------------------");
            Console.WriteLine("flightName:" + fd.flightName);
            Console.WriteLine("flightId:" + fd.flightId);
            Console.WriteLine("source:" + fd.source);
            Console.WriteLine("destination:" + fd.destination);
            Console.WriteLine("departureTiming:" + fd.departureTiming);
            Console.WriteLine("arrivalTiming:" + fd.arrivalTiming);

           Console.WriteLine("--------------------------------------------------------------------------------------------");

            Console.WriteLine("--------------------SCHEDULE LIST------------------------------------------------------------");
            Console.WriteLine("flightName    flightId      source       destination     departureTiming       arrivalTiming");


            Console.WriteLine("----------------------------------------------------------------------------------------------");


            FlightDetailsMenu();
            Console.ReadKey();
        }

         static void FlightDetailsMenu()
        {
            int choice = 1;
            do
            {
                Console.WriteLine("========FLIGHT MENU=========");
                Console.WriteLine("1. AddNewFlighDetails");
                Console.WriteLine("2. Update FlightDetails");
                Console.WriteLine("3. View FlightDetail");
                Console.WriteLine("4. Delete FlightDetail");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddNewFlightDetails(); break;
                    case 2: ViewFlightDetails(); break;
                    case 3: UpdateFlightDetails(); break;
                    case 4: DeleteFlightDetails(); break;

                }

            } while (choice != 5);
        }

        static void AddNewFlightDetails()
        {
            int choice1 = 1;
            FlightDetail fd = new FlightDetail();
            FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();
            do
            {
                Console.WriteLine("Enter your choice  to add Particular FlightDetails");
                Console.WriteLine("1.FlightName:");
                Console.WriteLine("2.FlightId");
                Console.WriteLine("3.Source");
                Console.WriteLine("4.destination");
                Console.WriteLine("5.DepartureTiming");
                Console.WriteLine("6.ArrivalTiming");

                switch (choice1)
                {
                    case 1:
                        Console.Write("Enter New flight to be added: ");
                        fd.flightName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter new flight Id to be added : ");
                        fd.flightId = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Enter new Source: ");
                        fd.source = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter New destination: ");
                        fd.destination = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Enter New DepartureTiming: ");
                        fd.departureTiming = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Enter New ArrivalTiming: ");
                        fd.arrivalTiming = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("flightDetails are  added successfully \n");
                        break;
                    default:
                        System.Console.WriteLine("Enter valid Option");
                        break;

                }

            } while (choice1 <= 7);

        }

            
        static void ViewFlightDetails()
        {
            
            List<FlightDetail> f = flightBusinessLogic.GetFlightDetails();

            foreach(FlightDetail fd in f)
            {
                Console.WriteLine(fd.flightId + ", " + fd.flightName + " ," + fd.source + "," + fd.destination + "," + fd.arrivalTiming + "," + fd.departureTiming);
                   
            }
        }


        static void UpdateFlightDetails()
        {

           int choice2 = 1;
           FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();
           FlightDetail fd = new FlightDetail();
            do
            {
                Console.WriteLine("Enter your option for updating Particular FlightDetails");
                Console.WriteLine("1.FlightName:");
                Console.WriteLine("2.FlightId");
                Console.WriteLine("3.Source");
                Console.WriteLine("4.destination");
                Console.WriteLine("5.DepartureTiming");
               Console.WriteLine("6.ArrivalTiming");

                switch (choice2)
                {

                    case 1:
                        Console.Write("Enter New flight Name: ");
                        fd.flightName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter new flight Id : ");
                        fd.flightId = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Enter Source: ");
                        fd.source = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter New destination: ");
                        fd.destination = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Enter New DepartureTiming: ");
                        fd.departureTiming = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Enter New ArrivalTiming: ");
                        fd.arrivalTiming = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("flightDetails are  Updated successfully \n");
                        break;
                    default:
                        System.Console.WriteLine("Enter valid Option");
                        break;

                }

            } while (choice2 <= 7);        
            
        }

        static void DeleteFlightDetails()
        {
            FlightDetailBusinessLogic flightBusinessLogic = new FlightDetailBusinessLogic();
            FlightDetail fd = new FlightDetail();
            Console.WriteLine("enter the flightName you wish to delete:");
            string flightName = Console.ReadLine();
            fd.Remove(flightName);
            flightBusinessLogic.DeleteFlightDetails(fd);
            Console.WriteLine("flight deleted succcessfully.\n");
        }

      
     




    }


}
        