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


            FlightSchedule fs = new FlightSchedule();
            FlightScheduleBusinessLogic flighscheduletBusinessLogic = new FlightScheduleBusinessLogic();

            // Set data into object "fs"

           Console.Write("Enter source:"); // Enter "FROM" Address
            fs.Source = Console.ReadLine();

           Console.Write("Enter destination:"); //enter "To" Addrress
            fs.destination = Console.ReadLine();

            //DateTime used to represent date and time of the Day

            Console.WriteLine("enter Departure Timing:"); //
            var userDate = Console.ReadLine();
            System.DateTime UserDateTime;  //  DateTime is of type DateTime Datatype
            System.DateTime.TryParse(Console.ReadLine(), out UserDateTime);
            Console.ReadLine();
            fs.departureTiming = Console.ReadLine();

            Console.WriteLine("enter Arrival Timing:");
            var inputtedDate = Console.ReadLine();
            System.DateTime result;
            System.DateTime.TryParse(inputtedDate, out result);
            fs.arrivalTiming = Console.ReadLine();


            // Display the Flight Details

            // get the data from "fd" object

            Console.WriteLine("---------------FLIGHT SCHEDULE---------------------------------------------");
           
            Console.WriteLine("source:" + fs.source);
            Console.WriteLine("destination:" + fs.destination);
            Console.WriteLine("departureTiming:" + fs.departureTiming);
            Console.WriteLine("arrivalTiming:" + fs.arrivalTiming);

           Console.WriteLine("--------------------------------------------------------------------------------------------");

            Console.WriteLine("--------------------SCHEDULE LIST------------------------------------------------------------");
            Console.WriteLine("  source       destination     departureTiming       arrivalTiming");


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
                Console.WriteLine("1. AddNewFlightSchedule");
                Console.WriteLine("2. Update FlightSchedule");
                Console.WriteLine("3. View FlightSchedule");
                Console.WriteLine("4. Delete FlightSchedule");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddNewFlightSchedule(); break;
                    case 2: ViewFlightSchedule(); break;
                    case 3: UpdateFlightSchedule(); break;
                    case 4: DeleteFlightSchedule(); break;

                }

            } while (choice != 5);
        }

        static void AddNewFlightSchedule()
        {
            int choice1 = 1;
           FlightSchedule fs = new FlightSchedule();
            FlightScheduleBusinessLogic flightscheduleBusinessLogic = new FlightScheduleBusinessLogic();
            do
            {
                Console.WriteLine("Enter your choice  to add Particular FlightDetails");
                
                Console.WriteLine("1.Source");
                Console.WriteLine("2.destination");
                Console.WriteLine("3.DepartureTiming");
                Console.WriteLine("4.ArrivalTiming");

                switch (choice1)
                {
                   
                    case 1:
                        Console.Write("Enter new Source: ");
                        fs.source = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter New destination: ");
                        fs.destination = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Enter New DepartureTiming: ");
                        fs.departureTiming = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter New ArrivalTiming: ");
                        fs.arrivalTiming = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("FlightSchedule is  added successfully \n");
                        break;
                    default:
                        System.Console.WriteLine("Enter valid Option");
                        break;

                }

            } while (choice1 <= 5);

        }

            
        static void ViewFlightSchedule()
        {
            
            List<FlightSchedule> f = flightscheduleBusinessLogic.GetFlightDetails();

            foreach(FlightSchedule fs in f)
            {
                Console.WriteLine( fs.source + "," + fs.destination + "," + fs.arrivalTiming + "," + fs.departureTiming);
                   
            }
        }


        static void UpdateFlightSchedule()
        {

           int choice2 = 1;
            FlightScheduleBusinessLogic flightscheduleBusinessLogic = new FlightScheduleBusinessLogic();
            FlightSchedule fs = new FlightSchedule();
            do
            {
                Console.WriteLine("Enter your option for updating Particular FlightSchedule :");
               
                Console.WriteLine("1.Source");
                Console.WriteLine("2.destination");
                Console.WriteLine("3.DepartureTiming");
               Console.WriteLine("4.ArrivalTiming");

                switch (choice2)
                {

                   
                    case 1:
                        Console.Write("Enter Source: ");
                        fs.source = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter New destination: ");
                        fs.destination = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Enter New DepartureTiming: ");
                        fs.departureTiming = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter New ArrivalTiming: ");
                        fs.arrivalTiming = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("FlightSchedule is  Updated successfully \n");
                        break;
                    default:
                        System.Console.WriteLine("Enter valid Option");
                        break;

                }

            } while (choice2 <= 7);        
            
        }

        static void DeleteFlightSchedule()
        {
            FlightScheduleBusinessLogic flightscheduleBusinessLogic = new FlightScheduleBusinessLogic();
            FlightSchedule fs = new FlightSchedule();
            Console.WriteLine("enter the flightName you wish to delete:");
            string flightName = Console.ReadLine();
            fs.Remove(flightName);
            flightBusinessLogic.DeleteFlightSchedule(fs);
            Console.WriteLine("flight deleted succcessfully.\n");
        }

      
     




    }


}
        