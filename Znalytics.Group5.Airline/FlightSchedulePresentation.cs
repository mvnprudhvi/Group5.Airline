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
        private string scheduleNumber;
        private string flightName;
        private string flightNumber;
        private string flightCapacity;
        private string luggageWeightage;
        private string source;
        private string destination;
        private string departureTiming;
        private string arrivalTiming;

        static void Main()
        {




            //Create collection of Flight type and initialize objects into collection  with collection initializer
            List<FlightSchedule> flightSchedule = new List<FlightSchedule>() {
             new FlightSchedule() {scheduleNumber ="1", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
             new FlightSchedule() { scheduleNumber = "2", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
             new FlightSchedule() { scheduleNumber = "3", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
             new FlightSchedule() { scheduleNumber = "4", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
             new FlightSchedule() { scheduleNumber = "5", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
             new FlightSchedule() { scheduleNumber = "6", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
             new FlightSchedule() { scheduleNumber = "7", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
             new FlightSchedule() { scheduleNumber = "8", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" }
            };



            // get objects from Collections
            foreach (FlightSchedule item in flightSchedule)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("--------------------------------------------------------------------------------------------");

            Console.WriteLine("--------------------SCHEDULE LIST------------------------------------------------------------");
            Console.WriteLine(" FlightName  FlightNumber   FlightCapacity   LuggageWeightage   source     destination     departureTiming       arrivalTiming");


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

            //create another list in the collection called  "flightschedule1"
            List<FlightSchedule> flightSchedule1 = new List<FlightSchedule>() {
                 new FlightSchedule() { scheduleNumber = "9", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
                 new FlightSchedule() { scheduleNumber = "10", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
                 new FlightSchedule() { scheduleNumber = "11", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
                 new FlightSchedule() { scheduleNumber = "12", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" },
                 new FlightSchedule() { scheduleNumber = "13", flightName = "AirIndia", flightNumber = "101", flightCapacity = "7kgs", luggageWeightage = "30kgs", source = "Hyderabad", destination = "Mumbai", departureTiming = "2020-08-29 7:30:00 AM", arrivalTiming = " 2020-08-29 7:30:00 Am" }
                 };

            // add all the elements of "flightSchedule1" collection at the end of "flightschedule" colletion
            flightSchedule.AddRange(flightSchedule1);

            //get values from list collection
            foreach (FlightSchedule item in flightSchedule)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void ViewFlightSchedule()
        {

            List<FlightSchedule> f = flightscheduleBusinessLogic.GetFlightSchedule();
            FlightSchedule fs = new FlightSchedule();

            foreach (FlightSchedule item in f)
            {
                Console.WriteLine(fs.flightName + "," + fs.flightNumber + "," + fs.flightCapacity + "," + fs.luggageWeightage + "," + fs.source + "," + fs.destination + "," + fs.arrivalTiming + "," + fs.departureTiming);

            }
        }




        /* int choice1 = 1;
         FlightSchedule fs = new FlightSchedule();
         FlightScheduleBusinessLogic flightscheduleBusinessLogic = new FlightScheduleBusinessLogic();
         do
         {
             Console.WriteLine("Enter your choice  to add  Particular FlightSchedule");

             Console.WriteLine("1.f1");
             Console.WriteLine("2.f2");
             Console.WriteLine("3.f3");
             Console.WriteLine("4.f4");
             Console.WriteLine("5.f5");
             Console.WriteLine("6.f6");
             Console.WriteLine("7.f7");
             Console.WriteLine("8.f8");

             switch (choice1)
             {

                 case 1:
                     Console.Write("Enter new Source: ");

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
         Console.WriteLine("flight deleted succcessfully.\n");  */
    }



}



    }


}
        
        