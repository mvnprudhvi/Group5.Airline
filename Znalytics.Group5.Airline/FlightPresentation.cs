//......KEERTHANA........

using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;
using Znalytics.Group5.Airline.Entities;
using System.Linq;
using System.Linq.Expressions;
using System.Net;



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
            //Login pagr for flight Administrator
            Console.WriteLine("ONLINE AIRLINE RESERVATION SYSTEM ");
            Console.WriteLine("==================================");
            Console.Write("\nuserName:");
            string userName = Console.ReadLine();
            System.Console.Write("Password:");
            string password = Console.ReadLine();

            if (userName == "Admin" && password == "manager")
            {
                AirlineMenu();
                Console.ReadKey();
            }
        }
        static void AirlineMenu()
        {
            int choice = 0;

            //using doWhile loop for Menu
            do
            {
                Console.WriteLine("::::::::::: AirlineMenu::::::::: ");
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
            int choice = 0;
            do
            {
                Console.WriteLine(" ====FLIGHTSMENU==== ");
                Console.WriteLine("1.AddFlight");
                Console.WriteLine("2.GetFlights");
                Console.WriteLine("3.GetFlightByflightId");
                Console.WriteLine("4.UpdateFlights");
                Console.WriteLine("5.RemoveFlight");



                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddFlight(); break;
                        case 2: GetFlights(); break;
                        case 3: GetFlightByflightId(); break;
                        case 4: UpdateFlight(); break;
                        case 5: RemoveFlight(); break;
                        case 6: Console.WriteLine("Exit"); break;


                    }
                }
            } while (choice <= 6);
        }

        //method to add Flightdetails to the list
        static void AddFlight()
        {
            try
            {

                //Creating object for Entity layer that is Flight class
                Flight flight = new Flight();

                //create  businessLogicLayer object for flight class
                FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();
                Console.WriteLine("you chose to enter the flight details");
                Console.WriteLine("Enter flight Id that starts with FID and length should be 8");
                flight.FlightId = Console.ReadLine();
                if (fbl.CheckFlightId(flight.FlightId) == false)
                {

                    System.Console.Write("Enter FlightName:"); //name of particular flight
                    flight.FlightName = System.Console.ReadLine();


                    System.Console.Write("Enter FlightType:"); // enter flight type of the flight (i.e,Economy/Business)
                    flight.FlightType = System.Console.ReadLine();

                    System.Console.Write("Enter LuggageWeightage:"); //weight of the luggage carried by the passengers
                    flight.LuggageWeightage = System.Console.ReadLine();

                    System.Console.Write("Enter no of Business Seats:"); //Business seats in flight
                    int NoOfBusinessSeats = int.Parse(System.Console.ReadLine());

                    System.Console.Write("Enter no of Economy seats:"); //weight of the luggage carried by the passengers
                    int NoOfEconomySeats = int.Parse(System.Console.ReadLine());

                    //creating object for Business logic layer 

                    fbl.AddFlight(flight);
                    Console.WriteLine("//Flight Details are ADDED successfully.\n");
                }
                else
                {
                    Console.WriteLine(" flight alreadt exists");
                }
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
        //method to get added flight details i.e.,View existing Flight Details
        public static void GetFlights()
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

        //methods to get flightdetails by flight id
        public static void GetFlightByflightId()
        {
            try
            {
                FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();
                Console.WriteLine("Enter exixting flightId");
                string fId = Console.ReadLine();
                Flight f = fbl.GetFlightByFlightId(fId);
                if(f != null)
                {
                    Console.WriteLine("flightID" + "   " + "flightName" + "  " + "flightType"+ " " + "flightCapacity" + " " + "luggageWeitage" + " " + "noOfBusinessSeats" +  " " + "noOfEconomySeats");
                    Console.WriteLine(f.FlightId + "  " + f.FlightName + "  " + f.FlightType + " " + f.FlightCapacity + " " + f.LuggageWeightage + " " + f.NoOfBusinessSeats + " " + f.NoOfEconomySeats);
                }
                else
                {
                    Console.WriteLine("flight doesn't exist");
                }
            }
            catch (FlightException ex)
            {
               Console. WriteLine(ex.Message);
            }


        }

        //methods to remove flight
        public static void RemoveFlight()
        {
            // creating the object for Flight class
            Flight f = new Flight();

            // Creating thhe object for FlightBusinessLogicLayer class
            FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();
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


            //methods to remove flight based on flightId
            
            void RemovetFlightByFlightId()
            {
                Flight flight = new Flight();
                Console.Write("Enter the flightId to be Deleted:");
                string flightId = Console.ReadLine();
                try
                {
                    if(fbl.GetFlightByFlightId(flight.FlightId) == null)
                    {
                        fbl.RemovetFlightByFlightId(flightId);
                        Console.WriteLine("flight is removed");
                    }
                }
                catch (FlightException ex)
                {
                   Console. WriteLine(ex.Message);
                }

               

            }

            //methods to remove flight based on flightname
            void RemoveFlightByFlightName()
            {
                Flight flight = new Flight();
                Console.Write("Enter the flightName to be Deleted:");
                string flightName = Console.ReadLine();
                try
                {
                    if (fbl.GetFlightByFlightId(flight.FlightName) == null)
                    {
                        fbl.RemoveFlightByFlightName(flightName);
                        Console.WriteLine("flight is removed");
                    }
                }
                catch (FlightException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        //method to update flight
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
                        UpdateFlightByFlightName(); break;
                    case 2:
                        UpdateFlightByFlightId(); break;
                    default: Console.WriteLine("Enter correct option"); break;

                }
            }

            //method to update flight based on flightname
            void UpdateFlightByFlightName()
            {
                try
                {

                    Console.WriteLine("Enter Existing flight Id");
                    string fID = Console.ReadLine();
                    Flight f = fbl.GetFlightByFlightId(fID);
                    if (f != null)
                    {
                        Console.WriteLine("Enter new name for Flight");
                        f.FlightName = Console.ReadLine();
                        fbl.UpdateFlightByFlightName(f);
                        Console.WriteLine("flight Name Updated Sucessfully!!!");
                    }
                    else
                    {
                       Console. WriteLine("flight id doesn't exist");
                    }
                }
                catch(FlightException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //method to update flight based on flightId

            void UpdateFlightByFlightId()
            {
                try
                {

                    Console.WriteLine("Enter Existing flight Id");
                    string fID = Console.ReadLine();
                    Flight f = fbl.GetFlightByFlightId(fID);
                    if (f != null)
                    {
                        Console.WriteLine("Enter new FlightId");
                        f.FlightId = Console.ReadLine();
                        fbl.UpdateFlightByFlightId(f);
                        Console.WriteLine("flight Name Updated Sucessfully!!!");
                    }
                    else
                    {
                        Console.WriteLine("flight id doesn't exist");
                    }
                }
                catch (FlightException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        //Represents flightScheduleMenu
        public static void FlightsScheduleMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine(" ====FLIGHTSCHEDULE MENU==== ");
                Console.WriteLine("1.AddSchedule");
                Console.WriteLine("2.GetSchedule");
                Console.WriteLine("3.GetScheduleByFlightScheduleId");
                Console.WriteLine("4.GetScheduleBySource");
                Console.WriteLine("5.UpdateSchedule");
                Console.WriteLine("6.RemoveSchedule");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddSchedule(); break;
                        case 2: GetSchedule(); break;
                        case 3: GetScheduleByFlightScheduleId(); break;
                        case 4: GetScheduleBySource(); break;
                        case 5: UpdateSchedule(); break;
                        case 6: RemoveSchedule(); break;

                    }
                }
            } while (choice <= 6);
        }

        /// <summary>
        /// Method to add Flightschedules to the list
        /// </summary>
        public static void AddSchedule()
        {
            try
            {

                //create object for flightSchedule
                FlightSchedule fs = new FlightSchedule();

                //create object for fligthBusiness layer
                FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();

                Console.WriteLine("You choose to add schedule to the repecitive flight");
                fs.FlightScheduleId = Console.ReadLine();
                if (fsbl.checkFlightScheduleId(fs.FlightScheduleId) == false)
                {

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

                    fsbl.AddSchedule(fs);

                    Console.WriteLine("schedule is  added successfully");
                }
                else
                {
                    Console.WriteLine(" flightSchedule already exists");
                }
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

        /// <summary>
        ///  Method to get added details of flightSchedule
        /// </summary>
        public static void GetSchedule()
        {
            FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
            List<FlightSchedule> ScheduleList = fsbl.GetSchedule();

            Console.WriteLine("===============   Flight Details=============");
            Console.WriteLine("flightscheduleId" + "   " + "source" + "  " + "destination" + "  " + "departureTiming" + "  " + "arrivalTiming");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (FlightSchedule item in ScheduleList)
            {
                Console.WriteLine(item.FlightScheduleId + "    " + item.Source + "  " + item.Destination + " " + item.DepartureTiming);// Displaying the products
            }

        }

        /// <summary>
        /// method to get flightSchedule by Source
        /// </summary>
        public static void GetScheduleBySource()
        {
            try
            {
                Console.WriteLine("Enter the  source");
                string source = Console.ReadLine();
                FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();

                List<FlightSchedule> _scheduleList = fsbl.GetScheduleBySource(source);
                if (_scheduleList != null)
                {
                    foreach (FlightSchedule fs in _scheduleList)
                    {

                        Console.WriteLine(fs.FlightId + "  " + fs.FlightScheduleId + "  " + fs.Source + " " + fs.Destination + " " + fs.DepartureTiming + " " + fs.ArrivalTiming);
                    }
                }
                else
                {
                    Console.WriteLine("source doesn't exist");
                }
            }
            catch (FlightException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //method to get flightSchedule by flightScheduleId
        public static void GetScheduleByFlightScheduleId()
        {

            try
            {
                FlightScheduleBusinessLogicLayer fsbl = new FlightScheduleBusinessLogicLayer();
                Console.WriteLine("Enter existing flightScheduleId");
                string fsId = Console.ReadLine();
               FlightSchedule fs = fsbl.GetScheduleByFlightScheduleId(fsId);
                if (fs != null)
                {
                    Console.WriteLine("FlightId "+ "  " +"FlightScheduleId" + "  " +"Source "+ " " + "Destination" + " " + "DepartureTiming "+ " " + "ArrivalTiming");
                    Console.WriteLine(fs.FlightId + "  " + fs.FlightScheduleId + "  " + fs.Source + " " + fs.Destination + " " + fs.DepartureTiming + " " + fs.ArrivalTiming);
                    
                }
                else
                {
                    Console.WriteLine("flightSchedule Id doesn't exist");
                }
            }
            catch (FlightException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
   


        
        
        
        //method to update schedule
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

            //method to update source by flightId
            void UpdateSource()
            {
                try
                {
                    FlightScheduleBusinessLogicLayer fbl = new FlightScheduleBusinessLogicLayer();
                    Console.WriteLine("Enter Existing flightSchedule ID");
                    string fsid = Console.ReadLine();

                    FlightSchedule fd = fsbl.GetScheduleByFlightScheduleId(fsid);
                    if (fd != null)
                    {
                        Console.WriteLine("Enter the new source for the Flight");
                        fd.Source = Console.ReadLine();

                        fsbl.UpdateSource(fd);
                        Console.WriteLine("Source Updated Sucessfully");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("flightSheduleId doesn't exists", ex);
                }


            }
            //method to update Destination by flightScheduleId

            void UpdateDestination()
            {
                try
                {
                    Console.WriteLine("Enter Existing flight Schedule ID");
                    string fsid = Console.ReadLine();
                    FlightSchedule schedule1 = fsbl.GetScheduleByFlightScheduleId(fsid);
                    if (schedule1 != null)
                    {
                        Console.WriteLine("Enter the new destination for the Flight");
                        schedule1.Destination = Console.ReadLine();

                        fsbl.UpdateSource(schedule1);
                        Console.WriteLine("Destination Updated Sucessfully");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("flightSheduleId doesn't exists", ex);
                }


            }

            //methods to update departure timings

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

            //methods to update Arrival timings
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

        //Represents removing of flightSchedule
        public static void RemoveSchedule()
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
                    case 2: RemoveFlightScheduleByFlightScheduleId(); break;
                    default: Console.WriteLine("Please Choose enter correct choice"); break;

                }

            }
            else
            {
                Console.WriteLine("the choice you entered is incorrect ..please ReEnter the choice ");
            }


            //Methods to remove Flightschedule by flightScheduleId
            void RemoveFlightScheduleByFlightId()
            {

                Console.Write("Enter the flightID of the FlightSchedule to be Deleted:");
                string flightId = Console.ReadLine();
                try
                {
                    if (fsbl.GetScheduleByFlightScheduleId(schedule.flightId) == null)
                    {
                        fsbl.RemoveFlightScheduleByFlightScheduleId(flightId);
                        Console.WriteLine("flightSchedule is Removed");
                    }
                }
                catch (FlightException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


            //method to remove FlightSchedule by FlightScheduleId
            void RemoveFlightScheduleByFlightScheduleId()
            {

                Console.Write("Enter the flightScheduleID of the FlightSchedule to be Deleted:");
                string flightScheduleId = Console.ReadLine();
                try
                {
                    if (fsbl.GetScheduleByFlightScheduleId(schedule.flightScheduleId) == null)
                    {
                        fsbl.RemoveFlightScheduleByFlightScheduleId(flightScheduleId);
                        Console.WriteLine("flightSchedule Removed");
                    }
                }
                catch (FlightException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    /// <summary>
    /// method to check flightId exists  or not
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
        public bool CheckFlightId(string id)
        {
            FlightBusinessLogicLayer fbl = new FlightBusinessLogicLayer();
            bool result = fbl.CheckFlightId(id);
            if (result == true)
            {
                Console.WriteLine("Flight Exists");
                return result;
            }
            return result;
        }
        /// <summary>
        /// method to check flightscheduleId exists  or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckFlightScheduleId(string id)
        {
            FlightScheduleBusinessLogicLayer fbl = new FlightScheduleBusinessLogicLayer();
            bool result = fbl.CheckFlightScheduleId(id);
            if (result == true)
            {
                Console.WriteLine("FlightSchedule already  Exists");
                return result;
            }
            return result;
        }
    }
}

       

       