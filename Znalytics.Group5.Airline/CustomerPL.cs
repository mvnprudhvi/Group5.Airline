//....MVN Prudhvi........

using System;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.BusinessLogicLayer;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

//Represents Presentation Layer

namespace Znalytic.Group5.Airline.PresentationLayer
{

    public class CustomerPL
    {
        static void Main()
        {

            Console.WriteLine("-----------------ONLINE AIRLINE RESERVATION SYSTEM----------------------:");

            CustomerAccountPage();
            Console.ReadKey();

            static void CustomerAccountPage()
            {
                int choice = -1;

                do
                {

                    Console.WriteLine("Enter 1 for sign up (Add Customer)");
                    Console.WriteLine("Enter 2 for Login");
                    Console.WriteLine("Enter 3 for Exit");
                    bool b = int.TryParse(Console.ReadLine(), out choice);
                    if (b == true)
                    {
                        switch (choice)
                        {
                            case 1: AddCustomer(); break;
                            case 2: Login(); break;
                        }
                    }
                } while (choice != 3);
            }

            static void AddCustomer()
            {
                try
                {
                    Customer c = new Customer();
                    CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();

                    //registration page
                    Console.WriteLine("REGISTRATION PAGE:");


                    Console.WriteLine("enter your ID:");
                    c.CustomerId = Console.ReadLine();

                    //customer user name
                    Console.WriteLine("enter your user name:");
                    c.CustomerUserName = Console.ReadLine();

                    //customer email
                    Console.WriteLine("enter your email:");
                    c.CustomerEmail = Console.ReadLine();

                    //customer password
                    Console.WriteLine("enter your password:");
                    c.CustomerPassword = Console.ReadLine();

                    //customer mobile number
                    Console.WriteLine("enter your mobile number:");
                    c.CustomerMobileNumber = Console.ReadLine();

                    //customer aadhar card number
                    Console.WriteLine("enter your aadhar card number:");
                    c.CustomerAadharNumber = Console.ReadLine();

                    //customer pan card number
                    Console.WriteLine("enter your pan card number:");
                    c.CustomerPanCardNumber = Console.ReadLine();

                    Console.WriteLine("Enter your Gender Male  or Female :");
                    c.CustomerGender = Console.ReadLine();

                    Console.WriteLine("userName:" + c.CustomerUserName);
                    Console.WriteLine("email:" + c.CustomerEmail);
                    Console.WriteLine("password:" + c.CustomerPassword);
                    Console.WriteLine("mobilenumber:" + c.CustomerMobileNumber);
                    Console.WriteLine("aadharnumber:" + c.CustomerAadharNumber);
                    Console.WriteLine("pancardnumber:" + c.CustomerPanCardNumber);
                    Console.WriteLine("Gender:" + c.CustomerGender);

                    customerBusinessLogicLayer.AddCustomer(c);
                    Console.WriteLine("Customer details added successfully");
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                }
            }
            static void Login()
            {

                //Login form
                Console.WriteLine("-------LOGIN FORM-----------------");
                Console.WriteLine("==================================");
                Console.WriteLine("\nUsername:");
                string userName = Console.ReadLine();
                Console.Write("Password:");
                string Password = Console.ReadLine();

                if (userName == "," && Password == ",")
                {
                    CustomersMenu();
                    Console.ReadKey();
                }

            }
            
            
        CustomersMenu:
            //represents customers menu
            static void CustomersMenu()
            {
            
                int choice2 = -1;

                do
                {
                    Console.WriteLine("Customers Menu:");
                    Console.WriteLine("Enter 1 to Update Customer");
                    Console.WriteLine("Enter 2 to Get Customer");
                    Console.WriteLine("Enter 3 to Delete Customer");
                    Console.WriteLine("Enter 4 to Exit");

                    bool b = int.TryParse(Console.ReadLine(), out choice2);
                    if (b == true)
                    {
                        switch (choice2)
                        {

                            case 1: UpdateCustomer(); break;
                            case 2: GetCustomer(); break;
                            case 3: DeleteCustomer(); break;

                        }
                    }
                } while (choice2 != 4);
            
        
        //update customer details
        static void UpdateCustomer()
            {
                Customer c = new Customer();
                CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();

                int choice3;

                Console.WriteLine("Enter your option for updating Particular detail");
                Console.WriteLine("For username enter 1");
                Console.WriteLine("For email enter 2");
                Console.WriteLine("For password enter 3");
                Console.WriteLine("for mobile number Enter 4 ");
                Console.WriteLine("For aadhar number Enter 5");
                Console.WriteLine("For pan card number Enter 6");
                Console.WriteLine("For gender Enter 7");
                Console.WriteLine("To Finish Modifiying Enter 8");
                Console.WriteLine("To Exit Enter 9");
                bool b = int.TryParse(Console.ReadLine(), out choice3);
                if (b == true)
                {
                    do
                    {
                        switch (choice3)
                        {
                            case 1:
                                Console.WriteLine("Enter your new username:");
                                c.CustomerUserName(Console.ReadLine());
                                break;

                            case 2:
                                Console.WriteLine("Enter Your new email:");
                                c.CustomerEmail = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter your new password:");
                                c.CustomerPassword = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter Your new mobile number:");
                                c.CustomerMobileNumber = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter your new aadhar Number:");
                                c.CustomerAadharNumber = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter Your new pan card number");
                                c.CustomerPanCardNumber = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter your gender:");
                                c.CustomerGender = Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("---------Mofification are finished-------");
                                break;

                            default:
                                Console.WriteLine("Enter valid Option");
                                break;

                        }

                    } while (choice3 <= 9);

                }

           
                else
                {
                    goto CustomersMenu;


                }
            }
        }

    

            //view customer details
        static void GetCustomer()
        {
            Customer c = new Customer();
            CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
            List<Customer> cust = customerBusinessLogicLayer.GetCustomer();

            foreach (Customer customer in cust)
            {
                Console.WriteLine(customer.CustomerId + "," + customer.CustomerUserName + ", " + customer.CustomerPassword + "," + customer.CustomerEmail + "," + customer.CustomerMobileNumber + "," + customer.CustomerAadharNumber + customer.CustomerPanCardNumber + "," + customer.CustomerGender + ",");
            }
        }

             static void GetCustomerByCustomerId()
            {
                Customer c = new Customer();
                Console.WriteLine("Enter existing Customer Id");
                string CustomerId = Console.ReadLine();
                CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
                Customer customer= customerBusinessLogicLayer.GetCustomerByCustomerId(CustomerId);
                Console.WriteLine(customer.CustomerId + "," + customer.CustomerUserName + ", " + customer.CustomerPassword + "," + customer.CustomerEmail + "," + customer.CustomerMobileNumber + "," + customer.CustomerAadharNumber + customer.CustomerPanCardNumber + "," + customer.CustomerGender + ",");

            }

            static void GetCustomerByCustomerUserName()
            {
                Customer c = new Customer();
                Console.WriteLine("Enter existing Customer User Name");
                string CustomerUserName = Console.ReadLine();
                CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
                Customer customer = customerBusinessLogicLayer.GetCustomerByCustomerId(CustomerUserName);
                Console.WriteLine(customer.CustomerId + "," + customer.CustomerUserName + ", " + customer.CustomerPassword + "," + customer.CustomerEmail + "," + customer.CustomerMobileNumber + "," + customer.CustomerAadharNumber + customer.CustomerPanCardNumber + "," + customer.CustomerGender + ",");
            }


                static void DeleteCustomer()
        {
                Customer c = new Customer();
                CustomerBusinessLogicLayer customerBusinessLogicLayer = new CustomerBusinessLogicLayer();
                Console.WriteLine("select the Option based on which you want to remove the Customer Account ");
                Console.WriteLine("Enter 1 by Customer Id");
                Console.WriteLine("Enter 2 by Customer UserName");
                int choice;
                bool b;
                b = int.TryParse(Console.ReadLine(), out choice);

                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: RemoveCustomerByCustomerId(); break;
                        case 2: RemoveCustomerByCustomerUserName(); break;
                        default: Console.WriteLine("Please Choose enter the correct choice"); break;

                    }

                }
                else
                {
                    Console.WriteLine("the choice you entered is incorrect ..please ReEnter the choice ");
                }
                void RemoveCustomerByCustomerId()
                {
                    Console.Write("Enter the CustomerId:");
                    string CustomerId = Console.ReadLine();

                    customerBusinessLogicLayer.RemoveCustomerScheduleByCustomerId(CustomerId);
                    Console.WriteLine("Your Account is Delete");


                }

                void RemoveCustomerByCustomerUserName()
                {
                    Console.Write("Enter the CustomerUserName:");
                    string CustomerUserName = Console.ReadLine();

                    customerBusinessLogicLayer.RemoveCustomerByCustomerUserName(CustomerUserName);
                    Console.WriteLine("Your Account is Deleted");


                }
            }
        }
    }
}
