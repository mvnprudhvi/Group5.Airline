using static System.Console;
namespace Znalytics.Group5.Airline
{
    class PricePL
    {
        static void Main()
        {
            //login
            WriteLine("AIRLINE PRICES");
            WriteLine("==================================");
            Write("\nUserName:");
            string userName = ReadLine();
            Write("\nPassword:");
            string password = ReadLine();
            if(userName=="system"&&password=="manager")
            {
                PriceMenu.Menu();
            }
               ReadKey();
        }
    }
}
