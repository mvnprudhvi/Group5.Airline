//......KEERTHANA........

using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;


//Represents Presentation Layer

namespace Znalytic.Group5.Airline.PresentationLayer
{

    class FlightPresentation
    {

        /// <summary>
        /// Beginning of the program
        /// </summary>
        static void Main()
        {

            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            int choice = 1;

            //using doWhile loop for Menu
            do
            {
                Console.WriteLine("::::::::::: MENU::::::::: ");
                Console.WriteLine("1.FlightsMenu");
                Console.WriteLine("2.FlightScheduleMenu");
                Console.WriteLine("3. exit");
                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: FlightsMenu(); break;
                        case 2: FlightsScheduleMenu(); break;
                    }
                }
            } while (choice != 4);
        }
        public static void FlightsMenu()

        {
            int choice = 1;
            do
            {
                Console.WriteLine(" ====FLIGHTSMENU==== ");
                Console.WriteLine("1.AddFlights");
                Console.WriteLine("2.UpdateFlights");
                Console.WriteLine("3.DeleteFlights");
                Console.WriteLine("4.GetFlights");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddFlight(); break;
                        case 2: UpdateFlight(); break;
                        case 3: Deleteflight(); break;
                        case 4: Getflights(); break;
                        case 5: Console.WriteLine("Exit"); break;



                    }
                }
            } while (choice <= 5);
        }

        //Represents Add FlightMethod
        static void AddFlight()
        {
            try
            {

                //Creating object for Entity layer that is Flight class
                Flight flight = new Flight();


                System.Console.Write("Enter FlightName:"); //name of particular flight
                flight.FlightName = System.Console.ReadLine();

                System.Console.Write("Enter FlightId:"); // enter flight id
                flight.FlightId = System.Console.ReadLine();

                System.Console.Write("Enter FlightType:"); // enter flight type of the flight (i.e,Economy/Business)
                flight.FlightType = System.Console.ReadLine();

                System.Console.Write("Enter FlightCapacity:"); //no of seats present in particual flight
                flight.FlightCapacity = System.Console.ReadLine();

                System.Console.Write("Enter LuggageWeightage:"); //weight of the luggage carried by the passengers
                flight.LuggageWeightage = System.Console.ReadLine();

                System.Console.Write("Enter no of Business Seats:"); //Business seats in flight
                flight.NoOfBusinessSeats = System.Console.ReadLine();

                System.Console.Write("Enter no of Economy seats:"); //weight of the luggage carried by the passengers
                flight.NoOfEconomySeats = System.Console.ReadLine();

                //creating object for Business logic layer 
                FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();
                fbl.AddFlight(flight);
                Console.WriteLine("//Flight Details are ADDED successfully.\n");
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                //Console.WriteLine();
                //Console.WriteLine(ex.StackTrace);
                //Console.WriteLine();
                // Console.WriteLine(ex.Source);
            }


        }
        //View existing Flight Details
        public static void Getflights()
        {
            //create object for Flight
            Flight flight = new Flight();

            //create object for BusinessLayer
            FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();

            //Creating  flightlist
            List<Flight> flightList = fbl.GetFlights();

            Console.WriteLine("==============================   FLIGHT DETAILS=============");
            Console.WriteLine("flightId" + "   " + "flightName" + "  " + "flightType" + " " + " flightCapacity" + " " + " luggageWeightage " + " " + " noOfBusinessSeats" + " " + "noOfEconomySeats");// Displaying the Flights;
            Console.WriteLine("-------------------------------------------------------------------=======------------------------------------");

            //Reads and get the details from flightList
            foreach (Flight fl in flightList)
            {
                Console.WriteLine(fl.FlightId + "    " + fl.FlightName + "  " + fl.FlightType + " " + fl.FlightCapacity + " " + fl.LuggageWeightage + " " + fl.NoOfBusinessSeats + " " + fl.NoOfEconomySeats);// Displaying the flights
            }

        }

        public static void GetflightByflightId()
        {
            Console.WriteLine("Enter exixting flightId");
            string flightId = Console.ReadLine();
            FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();
            Flight flight = fbl.GetFlightByFlightId(flightId);
            Console.WriteLine(flight.FlightId + " " + flight.FlightName);

        }

        public static void Deleteflight()
        {
            // creating the object for Flight class
            Flight f = new Flight();

            ;// Creating thhe object for FlightBusinessLogicLayer class
            FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();// Creating thhe object for FlightBusinessLogicLayer class
            Console.WriteLine("Choose the options to delete the Flight based on  the category");
            Console.WriteLine("1.by FlightId");
            Console.WriteLine("2.by FlightName");
            int Option;
            bool b;
            b = int.TryParse(Console.ReadLine(), out Option);

            if (b == true)
            {
                switch (Option)
                {
                    case 1: RemovetFlightByFlightId(); break;
                    case 2: RemoveFlightByFlightName(); break;
                    default: Console.WriteLine("Please Choose valid Option"); break;

                }

            }
            else
            {
                Console.WriteLine("Please Enter Correct Option");
            }
            void RemovetFlightByFlightId()
            {
                Console.Write("Enter the flightId to be Deleted:");
                string flightId = Console.ReadLine();

                fbl.RemovetFlightByFlightId(flightId);
                Console.WriteLine("flight Removed");


            }
            void RemoveFlightByFlightName()
            {
                Console.Write("Enter the Flight Name:");
                string flightName = Console.ReadLine();

                fbl.RemoveFlightByFlightName(flightName);
                Console.WriteLine("flight Removed");
            }
        }

        public static void UpdateFlight()
        {
            Flight f = new Flight();
            FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();
            Console.WriteLine("1. UpdateflightName");
            Console.WriteLine("2. UpdateflightId");


            int choice;
            bool b;

            b = int.TryParse(Console.ReadLine(), out choice);

            if (b == true)
            {
                switch (choice)
                {
                    case 1:
                        UpdateFlightName(); break;
                    case 2:
                        UpdateFlightId(); break;
                    default: Console.WriteLine("Enter correct option"); break;

                }
            }
            void UpdateFlightName()
            {

                Console.WriteLine("Enter Existing flight ID");
                 f.FlightId =int.Parse( Console.ReadLine());
                Console.WriteLine("Enter new name for Flight");
                f.FlightName = Console.ReadLine();
                fbl.UpdateFlightName(f);
                Console.WriteLine("flight Name Updated Sucessfully!!!");

            }
            void UpdateFlightId()
            {
                Console.WriteLine("Enter Existing WareHouse ID");
                f.FlightName = Console.ReadLine();
                Console.WriteLine("Enter new flight id");
                f.FlightId = Console.ReadLine();

                fbl.UpdateFlightId(f);
                Console.WriteLine("flightId is Updated Sucessfully!!!");
            }
        }



        public static void FlightsScheduleMenu()
        {
            int choice = 1;
            do
            {
                Console.WriteLine(" ====FlightScheduleMenu==== ");
                Console.WriteLine("1.AddSchedule");
                Console.WriteLine("2.UpdateSchedule");
                Console.WriteLine("3.GetSchedule");
                Console.WriteLine("3.DeleteSchedule");
                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddSchedule(); break;
                        case 2: UpdateSchedule(); break;
                        case 3: GetSchedule(); break;
                        case 4: DeleteSchedule(); break;




                    }
                }
            } while (choice <= 4);
        }
        public static void AddSchedule()
        {
            //create object for flightSchedule
            FlightSchedule fs = new FlightSchedule();

            //create object for fligthBusiness layer
            FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();

            Console.WriteLine("You choose to add schedule to the repecitive flight");
            Console.WriteLine("Enter Existing flightId");
            fs.flightId = Console.ReadLine();
            Console.WriteLine("Enter scheduleId");
            fs.Source = Console.ReadLine();
            Console.WriteLine("Enter source");
            fs.Source = Console.ReadLine();
            Console.WriteLine("Enter destination");
            fs.Destination = Console.ReadLine();
            Console.WriteLine("Enter DepartureTiming");
            fs.DepartureTiming = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(fs.DepartureTiming.ToString("dd/MM/yyyy hh:mm:s"));

            Console.WriteLine("Enter ArrivalTiming");
            fs.ArrivalTiming = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(fs.ArrivalTiming.ToString("dd/MM/yyyy hh:mm:s"));

            fbl.AddSchedule(fs);

            Console.WriteLine("schedule is  added successfully");

        }
        public static void GetSchedule()
        {
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
            List<FlightSchedule> ScheduleList = fsbl.GetSchedule();

            Console.WriteLine("===============   Flight Details=============");
            Console.WriteLine("flightscheduleId" + "   " + "source" + "  " + "destination" + "  " + "departureTiming" + "  " + "arrivalTiming");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (FlightSchedule item in ScheduleList)
            {
                Console.WriteLine(item.flightScheduleId + "    " + item.Source + "  " + item.Destination + " " + item.DepartureTiming);// Displaying the products
            }

        }
        public static void GetScheduleByFlightId()
        {

            Console.WriteLine("Enter the existing flight  Id");
            string flightId = Console.ReadLine();
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
            List<FlightSchedule> scheduleList = fsbl.GetScheduleByScheduleId(flightId);
            foreach (FlightSchedule item in scheduleList)
            {
                Console.WriteLine(item.FlightScheduleId + "    " + item.Source + "  " + item.Destination + " " + item.DepartureTiming + "  " + item.ArrivalTiming);// Displaying the schedules
            }

        }

        public static void GetScheduleByFlightScheduleId()
        {
            Console.WriteLine("Enter the existing flightScheduleId ");
            string flightScheduleId = Console.ReadLine();
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
            List<FlightSchedule> scheduleList = fsbl.GetScheduleByscheduleId(flightScheduleId);
            foreach (FlightSchedule item in scheduleList)
            {
                Console.WriteLine(item.FlightScheduleId + "    " + item.Source + "  " + item.Destination + " " + item.DepartureTiming + "  " + item.ArrivalTiming);// Displaying the schedules
            }

        }

        public static void GetScheduleBySource()
        {
            Console.WriteLine("Enter the Source");
            string source = Console.ReadLine();
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
            List<FlightSchedule> scheduleList = fsbl.GetScheduleBySource(source);
            foreach (FlightSchedule item in scheduleList)
            {
                Console.WriteLine(item.FlightScheduleId + "    " + item.Source + "  " + item.Destination + " " + item.DepartureTiming + "  " + item.ArrivalTiming);// Displaying the schedules
            }

        }

        public static void GetScheduleByDestination()
        {
            Console.WriteLine("Enter the destination :");
            string destination = Console.ReadLine();
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
            List<FlightSchedule> scheduleList = fsbl.GetScheduleByDestination(destination);
            foreach (FlightSchedule item in scheduleList)
            {
                Console.WriteLine(item.FlightScheduleId + "  " + item.Source + "  " + item.Destination + " " + item.DepartureTiming + "  " + item.ArrivalTiming);// Displaying the schedules
            }

        }
        public static void UpdateSchedule()
        {
            FlightSchedule schedule = new FlightSchedule();
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
            Console.WriteLine("1. Update source ");
            Console.WriteLine("2. Update Destination");
            Console.WriteLine("3. Update Departure Timing");
            Console.WriteLine("4. Update Arrival Timing");


            int choice;
            bool b;

            b = int.TryParse(Console.ReadLine(), out choice);

            if (b == true)
            {
                switch (choice)
                {
                    case 1:
                        UpdateSource(); break;
                    case 2:
                        UpdateDestination(); break;
                    case 3:
                        UpdateDepartureTiming(); break;
                    case 4:
                        UpdateArrivalTiming(); break;

                    default: Console.WriteLine("Enter correct option"); break;

                }
            }
            void UpdateSource()
            {
                try
                {
                    Console.WriteLine("Enter Existing flightSchedule ID");
                    schedule.flightScheduleId = Console.ReadLine();
                    FlightSchedule schedule1 = fsbl.GetSourceByFlightScheduleId(schedule1);
                    if (schedule1 != null)
                    {
                        Console.WriteLine("Enter the new source for the Flight");
                        schedule.Source = Console.ReadLine();

                        fsbl.UpdateSource(schedule);
                        Console.WriteLine("Source Updated Sucessfully");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("flightSheduleId doesn't exists", ex);
                }


            }

            void UpdateDestination()
            {
                try
                {
                    Console.WriteLine("Enter Existing flight Schedule ID");
                    schedule.flightScheduleId = Console.ReadLine();
                    FlightSchedule schedule1 = fsbl.GetSourceByFlightScheduleId(schedule1);
                    if (schedule1 != null)
                    {
                        Console.WriteLine("Enter the new source for the Flight");
                        schedule.Destination = Console.ReadLine();

                        fsbl.UpdateSource(schedule);
                        Console.WriteLine("Destination Updated Sucessfully");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("flightSheduleId doesn't exists", ex);
                }


            }

            void UpdateDepartureTiming()
            {

                Console.WriteLine("Enter Existing Schedule ID");
                schedule.flightScheduleId = Console.ReadLine();
                Console.WriteLine("Enter the new Departure Timing for the Flight");
                schedule.DepartureTiming = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(schedule.DepartureTiming.ToString("dd/MM/yyyy HH:mm:sec"));

                fsbl.UpdateDepartureTiming(schedule);
                Console.WriteLine("Source Updated Sucessfully!!!");

            }

            void UpdateArrivalTiming()
            {

                Console.WriteLine("Enter Existing Schedule ID");
                schedule.flightScheduleId = Console.ReadLine();
                Console.WriteLine("Enter the new Arrival Timing for the Flight");
                schedule.ArrivalTiming = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(schedule.ArrivalTiming.ToString("dd/MM/yyyy HH:mm:sec"));

                fsbl.UpdateArrivalTiming(schedule);
                Console.WriteLine("Arrival Updated Sucessfully!!!");

            }
        }

        public static void DeleteSchedule()
        {
            FlightSchedule schedule = new FlightSchedule();// creating the object for flightschedule class
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();//Creating the object for flightschedule BusinessLogic class
            Console.WriteLine("select the flight based on which you want to remove the flight schedule ");
            Console.WriteLine("1.by flightId");
            Console.WriteLine("2.by flilghtScheduleId");
            int choice;
            bool b;
            b = int.TryParse(Console.ReadLine(), out choice);

            if (b == true)
            {
                switch (choice)
                {
                    case 1: RemoveFlightScheduleByFlightId(); break;
                    case 2: RemoveFlightByFlightScheduleId(); break;
                    default: Console.WriteLine("Please Choose enter correct choice"); break;

                }

            }
            else
            {
                Console.WriteLine("the choice you entered is incorrect ..please ReEnter the choice ");
            }
            void RemoveFlightScheduleByFlightId()
            {
                Console.Write("Enter the flightId:");
                string flightId = Console.ReadLine();

                fsbl.RemoveFlightScheduleByFlightId(flightId);
                Console.WriteLine("Schedule is Removed");


            }

            void RemoveFlightByFlightScheduleId()
            {
                Console.Write("Enter the flightScheduleId:");
                string flightScheduleId = Console.ReadLine();

                fsbl.RemoveFlightByFlightScheduleId(flightScheduleId);
                Console.WriteLine("Schedule is Removed");


            }
        }
    }
}