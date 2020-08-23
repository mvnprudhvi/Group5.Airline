//created by Madhumitha
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
            FlightCancellationPresentation();
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
        }

        static void AddFlightName()
        {
            flightcancellationBusinessLogic = new FlightCancellationBusinessLogic();
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


