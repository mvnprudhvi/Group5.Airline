using static System.Console;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.BusinessLogicLayer;

namespace Znalytics.Group5.Airline
{
    /// <summary>
    /// This Class Represents Presentation Layer Of Price
    /// </summary>
    class PricePL
    {
        static void Main()
        {
            PricesMenu();
            ReadKey();
        }

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
                    case 1: AddPrice(); break;
                    case 2: DeletePrice(); break;
                    case 3: UpdatePrice(); break;
                    case 4: GetPrices(); break;
                }
            } while (choice != 5);
        }
        /// <summary>
        /// This Method Represents AddPrice
        /// </summary>
        static void AddPrice()
        {
            PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
            Price price = new Price();

            Write("Enter Flight ID: ");
            price.FlightID = int.Parse(ReadLine());

            Write("Enter Flight Name: ");
            price.FlightName = ReadLine();

            Write("Enter Flight Price: ");
            price.FlightPrice = double.Parse(ReadLine());

            priceBusinessLogic.AddPrice(price);
            WriteLine("The Details of Price Successfully Added \n");
        }


        static void UpdatePrice()
        {
            PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
            Price pr = new Price();

            Write("Enter Existing Flight Name: ");
            pr.FlightName = ReadLine();

            Write("Enter New Flight Price: ");
            pr.FlightPrice = double.Parse(ReadLine());

            priceBusinessLogic.UpdatePrice(pr);
            WriteLine("The Price of Flight Updated Successfully \n");
        }

        static void DeletePrice()
        {
            PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
            Price p = new Price();
            Write("Enter Existing Flight Name to Delete Price of Flight");
            priceBusinessLogic.DeletePrice(p);
            WriteLine("The Price Of Flight is Deleted Successfully \n");
        }

        static void GetPrices()
        {
            PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
            List<Price> pric = priceBusinessLogic.GetPrices();

            foreach (Price pri in pric)
            {
                Write("=====The Flight Prices are Below=====");
                WriteLine(pri.FlightName + "=" + pri.FlightPrice);
            }
        }
    }
}