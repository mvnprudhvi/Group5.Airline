class Program
{
    static void Main()
    {
        Airline a = new Airline();
        System.Console.WriteLine("Enter FlightNumber");
        a.SetCancel(System.Console.ReadLine());
        System.Console.WriteLine("view the details");
        a.SetView(System.Console.ReadLine());
        System.Console.WriteLine("Enter Time");
        a.SetCancel(System.Console.ReadLine());
        System.Console.WriteLine("enter Date");
        a.SetCancel(System.Console.ReadLine());
        System.Console.WriteLine("for cancellation");
        a.SetCancel(System.Console.ReadLine());
        System.Console.WriteLine(a.GetCancel());
        System.Console.WriteLine(a.GetView());
        System.Console.WriteLine(a.GetTime());
        System.Console.WriteLine(a.GetDate());
        System.Console.WriteLine(a.GetCancel());
    }
}