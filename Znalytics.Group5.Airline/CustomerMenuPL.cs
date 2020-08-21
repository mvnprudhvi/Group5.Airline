using System;
using System.Collections.Generic;

namespace Znalytics.Group5.Airline
{
    class CustomerMenu
    {
        public class MenuPresenter
        {
            public static void Menu()
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
                            case 3: viewCustomer(); break;
                            case 4: deleteCustomer(); break;

                        }
                    }
                } while (choice != 5);
            }

            public static void AddCustomer()
            {
                CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
                CustomerBusinessLogicLayer.AddCustomer(customer); //call BL
                CustomerMenu customer = new CustomerMenu();
                Console.Write("Enter new username: ");
                customer.UserName = Console.ReadLine();



                customerBusinessLogicLayer.Add(customer);
                Console.WriteLine("username added");
             }
           public static void UpdateCustomer()
            {
                CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
                Customer cust = new Customer();
                Console.Write("enter existing mobile number");
                cust.mobileNumber = int.Parse(Console.ReadLine());
                Console.Write("enter new mobile number");
                cust.mobileNumber = Console.ReadLine();
                customerBusinessLogicLayer.UpdateCustomer(Cust);
                Console.WriteLine("new mobile number is updated");

            }
        }
    }
}




 