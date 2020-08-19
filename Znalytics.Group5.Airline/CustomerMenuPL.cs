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
                    Console.WriteLine("9. Exit");

                    bool b = int.TryParse(Console.ReadLine(), out choice);
                    if (b == true)
                    {
                        switch (choice)
                        {
                            case 1: CustomersMenu(); break;
                        }
                    }
                } while (choice != 9);
            }

            public static void CustomersMenu()
            {
                int choice = -1;

                do
                {
                    Console.WriteLine("Customers Menu:");
                    Console.WriteLine("1. Add Customer");
                    Console.WriteLine("2. Update Customer");
                    Console.WriteLine("9. Exit");

                    bool b = int.TryParse(Console.ReadLine(), out choice);
                    if (b == true)
                    {
                        switch (choice)
                        {
                            case 1: AddCustomer(); break;
                        }
                    }
                } while (choice != 9);
            }

            public static void AddCustomer()
            {
                CustomerMenu customer = new CustomerMenu();
                Console.Write("Enter customer name: ");
                customer.Customer = Console.ReadLine();

                CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
                customerBusinessLogicLayer.AddCustomer(customer); //call BL
            }
        }
    }




 