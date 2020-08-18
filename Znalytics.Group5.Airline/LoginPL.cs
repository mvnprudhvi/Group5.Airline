using static System.Console;

namespace Znalytics.Group5
{
    namespace Airline.PL
    {
        class Program
        {
            static void Main()
            {
                //Login
                WriteLine("ONLINE SHOPPING");
                WriteLine("==================================");
                Write("\nUsername:");
                string userName = ReadLine();
                System.Console.Write("Password:");
                string password = ReadLine();

                if (userName == "system" && password == "manager")
                {
                    MenuPresenter.Menu();
                }

                ReadKey();
            }
        }
    }
}
