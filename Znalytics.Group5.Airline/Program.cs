/*class Program
{
    static void Main()
    {
        Registration r = new Registration();
        System.Console.WriteLine("registration page:");

        System.Console.WriteLine("enter your full name:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.WriteLine("enter your username:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.WriteLine("enter your password:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.WriteLine("enter your email:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.WriteLine("enter your mobile number:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.WriteLine("enter your aadhar card number:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.WriteLine("enter your pan card number:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.WriteLine("enter your gender:");
        r.SetFullName(System.Console.ReadLine());
        System.Console.WriteLine(r.GetFullName());

        System.Console.ReadKey();

    }
}*/


class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter flight name");
        string FlightName = System.Console.ReadLine();
        System.Console.WriteLine("Enter Date:");
        string Date = System.Console.ReadLine();
        System.Console.WriteLine("Enter Time");
        string Time = System.Console.ReadLine();
        System.Console.WriteLine("cancellation");
        string Cancel = System.Console.ReadLine();


        System.Console.WriteLine("flightname"); //get method will be called
        System.Console.WriteLine("Date"); //get method will be called
        System.Console.WriteLine("Time"); //get method will be called 
        System.Console.WriteLine("Cancel"); //get method will be called
        System.Console.ReadKey();
    }
}