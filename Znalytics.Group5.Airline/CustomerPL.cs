class Program
{
    static void Main()
    {

        System.Console.WriteLine("registration page:");


        System.Console.WriteLine("enter your first name:");
        string firstname = System.Console.ReadLine();

        System.Console.WriteLine("enter your last name:");
        string lastname = System.Console.ReadLine();

        System.Console.WriteLine("enter your email:");
        string email = System.Console.ReadLine();


        System.Console.WriteLine("enter your password:");
        string password = System.Console.ReadLine();


        System.Console.WriteLine("enter your mobile number:");
        string mobilenumber = System.Console.ReadLine();


        System.Console.WriteLine("enter your aadhar card number:");
        string aadharcardnumber = System.Console.ReadLine();


        System.Console.WriteLine("enter your pan card number:");
        string pancardnumber = System.Console.ReadLine();


        Customer customer = new Customer(firstname, lastname, email, password, mobilenumber, aadharcardnumber, pancardnumber);

        System.Console.ReadKey();

    }
}