//......KEERTHANA........

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Znalytic.Group5.Airline.BussinessLogicLayer;
using Znalytic.Group5.Airline.BusinessLayer;
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
            do
            {
                Console.WriteLine(" MENU ");
                Console.WriteLine("1.FlightsMenu");
                Console.WriteLine("2.FlightScheduleMenu");
                Console.WriteLine("3. exit");
                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: FlightsMenu(); break;
                        case 2: FlightScheduleMenu(); break;
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
                Console.WriteLine("3.ViewFlights");
                Console.WriteLine("3.DeleteFlights");
                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddFlights(); break;
                        case 2: UpdateFlights(); break;
                        case 3: DisplayFlights(); break;
                        case 4: DeleteFlights(); break;      
                        case 5: ViewFlights(); break;


                    }
                }
            } while (choice != 5);
        }
        public static void AddFlights()
        {
            Flight flight = new Flight();

            System.Console.Write("Enter FlightName:"); //Name of the Flight
            flight.flightName = System.Console.ReadLine();

            System.Console.Write("Enter FlightNumber:"); // enter flight id
            flight.flightNumber = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter FlightType:"); // enter flight id
            flight.flightType = System.Console.ReadLine();

            System.Console.Write("Enter FlightCapacity:"); //no of seats present in particual flight
            flight.flightCapacity = System.Console.ReadLine();

            System.Console.Write("Enter LuggageWeightage:"); //weight of the luggage carried by the passengers
            flight.luggageWeightage = System.Console.ReadLine();

            Console.WriteLine("FlightName:" + flight.flightName);
            Console.WriteLine("FlightNumber:" + flight.flightNumber);
            Console.WriteLine("FlightType:" + flight.flightType);
            Console.WriteLine("FlightCapacity:" + flight.flightCapacity);
            Console.WriteLine("luggageWeightage:" + flight.luggageWeightage);


            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("--------------------SCHEDULE LIST----------------------------------------");
            Console.WriteLine(" FlightName  FlightNumber flightType  FlightCapacity   LuggageWeightage ");

            Console.WriteLine("-------------------------------------------------------------------------");

            IFlightBusinessLogicLayer flightBusinessLogicLayer = new FlightBusinessLogicLayer();
            flightBusinessLogicLayer.AddFlights(flight); //calls Businesslogiclayer

        }
        public static void UpdateFlights()
        {
            Flight flight = new Flight();
            IFlightBusinessLogicLayer flightBusinessLogicLayer = new FlightBusinessLogicLayer();

            Console.WriteLine("Enter existing FlightId:");
            flight.flightId = Console.ReadLine();
            Console.WriteLine("Enter New FlightName:");
            flight.flightName = Console.ReadLine();
            flightBusinessLogicLayer.UpdateFlightNameByFlightId(flight);
        }
            public static void DisplayFlightByFlightId()
            {

              Flight flight = new Flight();
             IFlightBusinessLogicLayer flightBusinessLogicLayer = new FlightBusinessLogicLayer();
             int choice = 1;
             System.Console.WriteLine("Enter your option to update particular  field:");
              System.Console.WriteLine("Enter 1: FlightName");
              System.Console.WriteLine("Enter 2: FlightNumber");
              System.Console.WriteLine("Enter 3: FlightCapacity");
              System.Console.WriteLine("Enter 4: luggageWeightage ");

              do
              {
                  switch (choice)
                  {
                      case 1:
                          Console.WriteLine("Enter existing FlightName:");
                          flight.flightName = Console.ReadLine();
                          Console.WriteLine("Enter New FlightName:");
                          flight.flightName = Console.ReadLine();
                          flightBusinessLogicLayer.UpdateFlights(flight);
                          Console.WriteLine("FlightName is updated successfully");
                          break;

                      case 2:
                          Console.WriteLine("Enter Your existing FlightNumber:");
                          flight.flightNumber = Convert.ToInt64(System.Console.ReadLine());
                          Console.WriteLine("Enter New FlightNumber:");
                          flight.flightNumber = Console.ReadLine();
                          flightBusinessLogicLayer.UpdateFlights(flight);
                          Console.WriteLine("FlightNumber is updated successfully");
                          break;
                      case 3:
                          Console.WriteLine("Enter existing FlightCapacity:");
                          flight.flightCapacity = Convert.ToInt64(System.Console.ReadLine());
                          Console.WriteLine("Enter New flight Capacity:");
                          flight.flightCapacity = Convert.ToInt64(Console.ReadLine());
                          flightBusinessLogicLayer.UpdateFlights(flight);
                          Console.WriteLine("flightCapacity is  updated successfully");
                          break;
                      case 4:
                          Console.WriteLine("Enter Your Luggage Weightage:");
                          flight.luggageWeightage = Convert.ToInt64(System.Console.ReadLine());
                          Console.WriteLine("Enter New Luggage weighhtage:");
                          flight.luggageWeightage = Convert.ToInt64(Console.ReadLine());
                          flightBusinessLogicLayer.UpdateFlights(flight);
                          Console.WriteLine("luggage weight is updated successfully ");
                          break;
                      default: Console.WriteLine("enter valid option:"); break;
                  }

              } while (choice != 5);

          }*/
            public static void ViewFlights()
        {
            IFlightBusinessLogicLayer flightBusinessLogicLayer = new FlightBusinessLogicLayer();
            List<Flight> f = flightBusinessLogicLayer.GetFlights();
            foreach (Flight item in f)
            {
                Console.WriteLine("flightName +", "+ flightNumber +", " + flightCapacity +", " +luggageWeightage");
            }

        }
        public static void DeleteFlights()
        {
            IFlightBusinessLogicLayer flightBusinessLogicLayer = new FlightBusinessLogicLayer();
            Flight flight = new Flight();
            Console.WriteLine("enter the flightName you wish to delete:");
            string flightName = Console.ReadLine();
            flight.Remove(flightName);
            flightBusinessLogicLayer.DeleteFlights(flight);
            Console.WriteLine("flight deleted succcessfully.\n");
        }



    }
      
}


