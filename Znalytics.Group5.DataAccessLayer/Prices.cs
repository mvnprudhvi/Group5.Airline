
class Airlineprices
{
  static void Main()
    {
        Airlineprices a = new Airlineprices();
        Airlineprices a1= new Airlineprices();
        Airlineprices a2= new Airlineprices();

        System.Console.WriteLine("=====Airline prices====");

        System.Console.WriteLine("Enter the price of flight-1:");
        a.SetPrice(double.Parse(System.Console.ReadLine()));

        System.Console.WriteLine("Enter the price of flight-2:");
        a1.SetPrice(double.Parse(System.Console.ReadLine()));

        System.Console.WriteLine("Enter the price of flight-3");
        a2.SetPrice(double.Parse(System.Console.ReadLine()));

        System.Console.WriteLine("the price of flight-1 is"+a.GetPrice());
        System.Console.WriteLine("the price of flight-1 is"+a1.GetPrice());
        System.Console.WriteLine("the price of flight-1 is"+a2.GetPrice());
    }
}
