using static System.Console;

namespace Znalytics.Group5.Airline.PL
{
    class PricePL
    {
        static void Main()
        {
            //login
            WriteLine("AIRLINE PRICES");
            WriteLine("=====================================");
            Write("\nUsername:");
            string userName = ReadLine();
            Write("\nPassword:");
            string password = ReadLine();
            if(userName == "system" && password == "manager")
            {
                MenyPresenter.Menu();
            }
            ReadKey();
        }
    }
}
