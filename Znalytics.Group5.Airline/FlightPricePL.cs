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
        //Reference Variable Of Price Business Logic Layer
        private static FlightPriceBusinessLogic _flightPriceBusinessLogic;
        /// <summary>
        ///This Represents Main Method of Flight Price
        /// </summary>
        static void Main()
        {
            //Creating Object for Flight Price Business Logic 
            _flightPriceBusinessLogic = new FlightPriceBusinessLogic();
            //Calling Menu Method For List Of Prices Menus Available in it
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
                WriteLine("=====PRICES MENU=====");
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
        /// This Method Represents to Add the Business price and Economy Price of Flight
        /// </summary>
        static void AddFlightPrice()
        {
            FlightPrice fp = new FlightPrice();

            Write("Enter the Schedule Id (Ex.FSID01): ");
            fp.FlightScheduleId =ReadLine();

            Write("Enter the Price For Business Class Seats: ");
            fp.PriceForBusinessClassSeat = double.Parse(ReadLine());

            Write("Enter the Price For Economy Class Seats: ");
            fp.PriceForEconomyClassSeat = double.Parse(ReadLine());

            _flightPriceBusinessLogic.AddFlightPrice(fp);
            WriteLine("The Details of Prices is Successfully Added \n");
        }

        /// <summary>
        /// This Method Represents to Delete the Price of Flight
        /// </summary>
        static void DeleteFlightPrice()
        {
            FlightPrice fpr = new FlightPrice();
            Write("Enter Existing Flight Schedule Id to Delete the All Prices of That Schedule: ");
            fpr.FlightScheduleId = ReadLine();
            _flightPriceBusinessLogic.DeleteFlightPrice(fpr);
             WriteLine("The Price Of Given Schedule is Successfully Deleted \n");
        }

        /// <summary>
        /// This Method Represents to Update the Business price and Economy Price of Flight
        /// </summary>
        static void UpdateFlightPrice()
        {
            FlightPrice fpri = new FlightPrice();

            Write("Enter Existing Schedule Id (Ex.FSID01): ");
            fpri.FlightScheduleId = ReadLine();

            Write("Enter the Price For Business Class Seats: ");
            fpri.PriceForBusinessClassSeat = double.Parse(ReadLine());

            Write("Enter the Price For Economy Class Seats: ");
            fpri.PriceForEconomyClassSeat = double.Parse(ReadLine());

            _flightPriceBusinessLogic.UpdateFlightPrice(fpri);
            WriteLine("The Price of Flight is Updated Successfully \n");
        }

        /// <summary>
        /// This Method Represents GetPrices To View prices of Flight
        /// </summary>
        static void GetFlightPrices()
        {
            List<FlightPrice> prs = _flightPriceBusinessLogic.GetFlightPrices();

            foreach (FlightPrice pri in prs)
            {
                WriteLine("=======The Flight Prices are Below=======");

                WriteLine("The Flight Id is: "+ pri.FlightId);
                WriteLine("The Flight Schedule Id is: " + pri.FlightScheduleId);
                WriteLine("The Price of Business Class Seats: "+pri.PriceForBusinessClassSeat);
                WriteLine("The Price of Economy Class Seats: "+pri.PriceForEconomyClassSeat);
            }
        }
         static void GetPriceByBeforeDays()
         {
            Write("Enter Number of Days Before U want the Ticket: ");

         }
    }
}