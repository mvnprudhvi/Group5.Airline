class Program
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

        System.Console.ReadKey();

    }
}