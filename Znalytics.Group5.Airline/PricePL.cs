/// <summary>
/// Created By Dinesh
/// Module Name is Price
/// </summary>

using static System.Console;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.BusinessLogicLayer;

namespace Znalytics.Group5.Airline.PresentationLayer
{
    /// <summary>
    /// This Class Represents Presentation Layer Of Price
    /// </summary>
    class PricePL
    {
       static  PriceBusinessLogic _priceBusinessLogic;
        /// <summary>
        /// Main Method
        /// </summary>
        static void Main()
        {
            _priceBusinessLogic = new PriceBusinessLogic;
            PricesMenu();//Calling Menu Method For List Of Menus
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
            FlightPrice price = new FlightPrice();

            Write("Enter Schedule ID: ");
            price.ScheduleId = int.Parse(ReadLine());

            Write("Enter Flight Price: ");
            price.Price = double.Parse(ReadLine());

            _priceBusinessLogic.AddFlightPrice(price);

            WriteLine("The Details of Price is Successfully Added \n");
        }

        /// <summary>
        /// This Method Represents Delete Price To Delete Price of Flight
        /// </summary>
        static void DeleteFlightPrice()
        {

            Price p = new Price();
            Write("Enter Existing Flight Name to Delete Price of That Flight");
            _priceBusinessLogic.DeleteFlightPrice(p);
            WriteLine("The Price Of Flight is Deleted Successfully \n");
        }

        /// <summary>
        /// This Method Represents Update Price to update Price of Flight
        /// </summary>
        static void UpdateFlightPrice()
        {
     
            Price pr = new Price();

            Write("Enter Existing Flight Name: ");
            pr.FlightName = ReadLine();

            Write("Enter New Flight Price: ");
            pr.FlightPrice = double.Parse(ReadLine());

            _priceBusinessLogic.UpdatePrice(pr);
            WriteLine("The Price of Flight is Updated Successfully \n");
        }

        /// <summary>
        /// This Method Represents GetPrices To View prices of Flight
        /// </summary>
        static void GetFlightPrices()
        {
          
            List<FlightPrice> pric = _priceBusinessLogic.GetPrices();

            foreach (Price pri in pric)
            {
                Write("=====The Flight Prices are Below=====");
                WriteLine(pri.FlightName + "=" + pri.FlightPrice);
            }
        }
    }
}