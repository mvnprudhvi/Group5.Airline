using static System.Console;

namespace Znalytics.Group5.Airline.PL
{
    class PricePL
    {
        static void Main()
        {
            //login
            WriteLine("AIRLINE PRICES");
            WriteLine("==================================");
            Write("\nUserName:");
            string userNane = ReadLine();
            Write("\nPassword:");
            string password = ReadLine();
            if(userNane=="system"&&password=="manager")
            {
                MenuPresenter.Menu();
            }
               ReadKey();
        }
    }
}
