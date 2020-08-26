//....MVN Prudhvi........

using System;
using System.Collections.Generic;
using System.Xml.Schema;
using Znalytic.Group5.Airline.BussinessLogicLayer;
using Znalytics.Group5.Airline.Entities;

//Represents Presentation Layer

namespace Znalytic.Group5.Airline.PresentationLayer
{

    public class CustomerPL
    {
        static void Main()
        {
            int Type;

            CustomerPL c = new CustomerPL();
            CustomerBusinessLogicLayer bll = new CustomerBusinessLogicLayer();

            Console.WriteLine("-----------------ONLINE AIRLINE RESERVATION SYSTEM----------------------:");

            //registration page
            Console.WriteLine("REGISTRATION PAGE:");

            //customer user name
            Console.WriteLine("enter your user name:");
            string username = Console.ReadLine();


            //customer email
            Console.WriteLine("enter your email:");
            string email = Console.ReadLine();

            //customer password
            Console.WriteLine("enter your password:");
            string password = Console.ReadLine();

            //customer mobile number
            Console.WriteLine("enter your mobile number:");
            long mobilenumber = Convert.ToInt64(Console.ReadLine());

            //customer aadhar card number
            Console.WriteLine("enter your aadhar card number:");
            int aadharnumber = Convert.ToInt32(Console.ReadLine());

            //customer pan card number
            Console.WriteLine("enter your pan card number:");
            string pancardnumber = Console.ReadLine();

            Console.WriteLine("Enter your Gender Male  or Female :");
            bool gender = int.TryParse(Console.ReadLine(), out Type);
            if (gender)
            {

            }




            System.Console.WriteLine("userName:" + username);
            System.Console.WriteLine("email:" + email);
            System.Console.WriteLine("password:" + password);
            System.Console.WriteLine("mobilenumber:" + mobilenumber);
            System.Console.WriteLine("aadharnumber:" + aadharnumber);
            System.Console.WriteLine("pancardnumber:" + pancardnumber);
            System.Console.WriteLine("Gender:" + gender);


            //Login form
            Console.WriteLine("-------LOGIN FORM-----------------");
            Console.WriteLine("==================================");
            Console.WriteLine("\nUsername:");
            string userName = Console.ReadLine();
            Console.Write("Password:");
            string Password = Console.ReadLine();

            if (userName == "," && password == ",")
            {
                Menu();
                Console.ReadKey();
            }

        }
        private static void Menu()
        {
            int choice = -1;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: CustomersMenu(); break;
                    }
                }
            } while (choice != 2);
        }
        //represents customers menu
        public static void CustomersMenu()
        {
            int choice = -1;

            do
            {
                Console.WriteLine("Customers Menu:");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Update Customer");
                Console.WriteLine("3. view Customer");
                Console.WriteLine("4. delete Customer");
                Console.WriteLine("5. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddCustomer(); break;
                        case 2: UpdateCustomer(); break;
                        case 3: ViewCustomer(); break;
                        case 4: DeleteCustomer(); break;

                    }
                }
            } while (choice != 5);
        }
        //add customer username
        static void AddCustomer()
        {
            CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            Customer customersmenu = new CustomersMenu();
            Console.Write("Enter new username: ");
            Customer.UserName = Console.ReadLine();
            customerBusinessLogicLayer.Add(cust);
            Console.WriteLine("username added");
        }

        //update customer details
        static void UpdateCustomer()
        {
            int choice2;
            System.Console.WriteLine("Enter your option for updating Particular detail");
            System.Console.WriteLine("For username enter 1");
            System.Console.WriteLine("For email enter 2");
            System.Console.WriteLine("For password enter 3");
            System.Console.WriteLine("for mobile number Enter 4 ");
            System.Console.WriteLine("For aadhar number Enter 5");
            System.Console.WriteLine("For pan card number Enter 6");
            System.Console.WriteLine("For gender Enter 7");
            System.Console.WriteLine("To Finish Modifiying Enter 8");
            bool c = int.TryParse(System.Console.ReadLine(), out choice2);
            if (c)
            {
                do
                {
                    switch (choice2)
                    {
                        case 1:
                            System.Console.WriteLine("Enter your new username:");
                            c.UserName = (System.Console.ReadLine());
                            break;

                        case 2:
                            System.Console.WriteLine("Enter Your new email:");
                            c.email = (System.Console.ReadLine());
                            break;
                        case 3:
                            System.Console.WriteLine("Enter your new password:");
                            c.password = (System.Convert.ToInt64(System.Console.ReadLine()));
                            break;
                        case 4:
                            System.Console.WriteLine("Enter Your new mobile number:");
                            c.mobilenumber = System.Console.ReadLine();
                            break;
                        case 5:
                            System.Console.WriteLine("Enter your new aadhar Number:");
                            c.aadharnumber = (System.Console.ReadLine());
                            break;
                        case 6:
                            System.Console.WriteLine("Enter Your new pan card number");
                            c.pancardnumber = (System.Console.ReadLine());
                            break;
                        case 7:
                            System.Console.WriteLine("Enter your gender:");
                            c.gender = (Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("---------Mofification are finished-------");


                        default:
                            Console.WriteLine("Enter valid Option");
                            break;

                    }

                } while (choice2 <= 8);
            }
            else
            {
                goto UpdateCustomer;
            }
        }

    }
}
            //view customer details
        static void ViewCustomer()
        {
            CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            List<Customer> cust = customerBusinessLogicLayer.GetCustomer();

            foreach (Customer customer in cust)
            {
                Console.WriteLine(customer.UserName + ", " + customer.password + "," + customer.email + "," + customer.mobileNumber + "," + customer.aadharNumber + customer.pancardNumber + "," + ",");
            }
        }

    }
}