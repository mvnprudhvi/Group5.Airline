/// <summary>
/// represents customer
/// </summary>
class Customer
{
    static void Main()
    {
        //registration page
        System.Console.WriteLine("REGISTRATION PAGE:");

        //customer user name
        System.Console.WriteLine("enter your user name:");
        string username = System.Console.ReadLine();
        //customer email
        System.Console.WriteLine("enter your email:");
        string email = System.Console.ReadLine();

        //customer password
        System.Console.WriteLine("enter your password:");
        string password = System.Console.ReadLine();

        //customer mobile number
        System.Console.WriteLine("enter your mobile number:");
        string mobilenumber = System.Console.ReadLine();

        //customer aadhar card number
        System.Console.WriteLine("enter your aadhar card number:");
        string aadharcardnumber = System.Console.ReadLine();

        //customer pan card number
        System.Console.WriteLine("enter your pan card number:");
        string pancardnumber = System.Console.ReadLine();

        //customer details are stored
        Customer customer = new Customer(username, email, password, mobilenumber, aadharcardnumber, pancardnumber);

        System.Console.ReadKey();

    }
}