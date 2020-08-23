using System;
using Znalytics.Group5.Airline.BusinessLogicLayer;.Entities;
using Znalytics.OnlineShopping.BusinessLogicLayer;

namespace Znalytics.OnlineShopping.PresentationLayer
{
    public class MenuPresenter
    {
        public static void Menu()
        {
            int choice = -1;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("9. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: CustomersMenu(); break;
                    }
                }
            } while (choice != 9);
        }

        public static void CustomersMenu()
        {
            int choice = -1;

            do
            {
                Console.WriteLine("Customers Menu:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Update Customer");
                Console.WriteLine("9. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddCustomer(); break;
                    }
                }
            } while (choice != 9);
        }

        public static void AddCustomer()
        {
            Customer customer = new Customer();
            Console.Write("Enter customer name: ");
            customer.CustomerName = Console.ReadLine();

            ICustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            customerBusinessLogicLayer.AddCustomer(customer); //call BL

            Console.WriteLine(customer.GetType()); //Output: Znalytics.OnlineShopping.CustomersModule.Entities.Customer

            Console.WriteLine(customer.ToString()); //Output: Znalytics.OnlineShopping.CustomersModule.Entities.Customer

            Console.WriteLine(customer.GetHashCode()); //Output: 46104728


            Customer customer1 = new Customer() { CustomerName = "John", Email = "john@gmail.com" };
            Customer customer2 = new Customer() { CustomerName = "John", Email = "john@gmail.com" };

            Console.WriteLine(customer1.Equals(customer2)); //Output: True 
        }
    }
}











































/*//created by Madhumitha
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
            TicketCancellationPresentation();
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

        static void AddFlightName()
        {
            FlightcancellationBusinessLogic = new FlightCancellationBusinessLogic();
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


