using static System.Console;
using Znalytics.Group5.Airline.BusinessLogicLayer;

namespace Znalytics.Group5.Airline
{
    public class PriceMenu
    {
        private static PriceBusinessLogic priceBusinessLogic = new PriceBusinessLogic();
        public static void Menu()
        {
            int choice = -1;

            do
            {
                  WriteLine("Prices Menu:");
                  WriteLine("1. Add Price");
                  WriteLine("2. Update Price");
                  WriteLine("9. Exit");

                bool b = int.TryParse(ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddPrice(); break;
                    }
                }
            } while (choice != 9);
        }

        public static void AddPrice()
        {
            Write("Enter the price:");
            double price = double.Parse(ReadLine());
            priceBusinessLogic.AddPrice(price);
        }
    }
}
