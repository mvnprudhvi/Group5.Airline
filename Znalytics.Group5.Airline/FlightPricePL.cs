/// <summary>
/// Created By Dinesh
/// Module Name is Flight Price
/// </summary>

using static System.Console;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.BusinessLogicLayer;
using System.Collections.Generic;

namespace Znalytics.Group5.Airline.PresentationLayer
{
    /// <summary>
    /// This Class Represents Presentation Layer Of Price
    /// </summary>
    class FlightPricePL
    {
        private static FlightPriceBusinessLogic _flightPriceBusinessLogic;//Reference Variable Of Price Business Logic Layer
        private static IEnumerable<FlightPrice> _flightPrices;

        /// <summary>
        /// Main Method
        /// </summary>
        static void Main()
        {
            _flightPriceBusinessLogic = new FlightPriceBusinessLogic();
            //Calling Menu Method For List Of Menus
            PricesMenu(); 
            ReadKey();
        }

        /// <summary>
        /// This Method Represents PriceMenu To View Operations Of Price
        /// </summary>
        static void PricesMenu()
        {
            int choice = 0;
            do
            {
                WriteLine("===PRICES MENU===");
                WriteLine("1. Add Flight Price");
                WriteLine("2. Delete Flight Price");
                WriteLine("3. Update Flight Price");
                WriteLine("4. View Flight Price");
                WriteLine("5. Exit");
                Write("Enter Your choice: ");
                choice = int.Parse(ReadLine());

                switch (choice)
                {
                    case 1: AddFlightPrice(); break;
                    case 2: DeleteFlightPrice(); break;
                    case 3: UpdateFlightPrice(); break;
                    case 4: GetFlightPrices(); break;
                }
            } while (choice != 5);
        }

        /// <summary>
        /// This Method Represents AddPrice to Add price of Flight
        /// </summary>
        static void AddFlightPrice()
        {
            FlightPrice fp = new FlightPrice();

            Write("Enter the Schedule Number: ");
            fp.ScheduleNumber = int.Parse(ReadLine());

            Write("Enter the Price For Business Class Seats: ");
            fp.PriceForBusinessClassSeat = double.Parse(ReadLine());

            Write("Enter the Price For Economy Class Seats: ");
            fp.PriceForEconomyClassSeat = double.Parse(ReadLine());

            _flightPriceBusinessLogic.AddFlightPrice(fp);

            WriteLine("The Details of Price is Successfully Added \n");
        }

        /// <summary>
        /// This Method Represents Delete Price To Delete Price of Flight
        /// </summary>
        static void DeleteFlightPrice()
        {

            FlightPrice fpr = new FlightPrice();
            Write("Enter Existing Flight Schedule Number to Delete Price of That Flight");
            _priceBusinessLogic.DeleteFlightPrice(fpr);
            WriteLine("The Price Of Flight is Deleted Successfully \n");
        }

        /// <summary>
        /// This Method Represents Update Price to update Price of Flight
        /// </summary>
        static void UpdateFlightPrice()
        {

            FlightPrice fpri = new FlightPrice();

            Write("Enter Existing Flight Schedule Number: ");
            fpri.ScheduleId =int.Parse(ReadLine());

            Write("Enter the Price For Business Class Seats: ");
            fpri.PriceForBusinessClassSeat = double.Parse(ReadLine());

            Write("Enter the Price For Economy Class Seats: ");
            fpri.PriceForEconomyClassSeat = double.Parse(ReadLine());

            _priceBusinessLogic.UpdateFlightPrice(fpri);
            WriteLine("The Price of Flight is Updated Successfully \n");
        }

        /// <summary>
        /// This Method Represents GetPrices To View prices of Flight
        /// </summary>
        static void GetFlightPrices()
        {
          
            List<FlightPrice> pric = _priceBusinessLogic.GetFlightPrices();

            foreach (FlightPrice pri in _flightPrices)
            {
                Write("=====The Flight Prices are Below=====");
                WriteLine("The Price of Business Class Seats "+pri.PriceForBusinessClassSeat);
                WriteLine("The Price of Economy Class Seats "+pri.PriceForEconomyClassSeat);
            }
        }
    }
}