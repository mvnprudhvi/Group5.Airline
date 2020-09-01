//Mvn prudhvi\\
/*using System;
using System.Linq;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.AirLine.Entities;
using Newtonsoft.Json;
using System.IO;

//Created a Namespace For DataAccess Layer For Customer Module
namespace Znalytics.Group5.Airline.DataAccessLayer
{
    /// <summary>
    /// Represents Class For Customer Data Access Layer
    /// </summary>
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        // Create a List For Customer
        private static List<Customer> _customer
        {
            set;
            get;
        }


        //Static Constructor
    static CustomerDataAccessLayer()
        {
            _customer = new List<Customer>();
        }

        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        private static void SaveIntoFile()
        {
            //Serialization converts an object into Json Format/String
            //Serialize object is stored in a reference variable of a string
            string s = JsonConvert.SerializeObject(_customer);

            //Strean Writer writes data into file.
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\Customer.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// reading the data from Json file and return the data in the file in List format
        /// </summary>
        /// <returns>Returns List of flightdetails  avaliable int Flight.Txt</returns>
        public List<Customer> GetFiledata()
        {
            //Stream Reader reads the data from the given file
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\Customer.txt");
            string str = streamReader.ReadToEnd();

            //Deserialization converts Json data/string to Object
            List<Customer> customer = JsonConvert.DeserializeObject<List<Customer>>(str);
            return customer;

        }

        /// <summary>
        /// Method To ADD Details To The List
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {

            if (_customer.Count == 0)
            {
                customer.CustomerId = 1;
            }
            else
            {
                customer.CustomerId = _customer.Max(temp => temp.CustomerId) + 1;
            }
            _customer.Add(customer);
            SaveIntoFile();
        }


        /// <summary>
        /// Method To  
        /// </summary>
        /// <returns></returns>
        public Tuple<string, string> CustomerLogin(string CustomerUserName,string CustomerPassword)
        {
            if (_customer.Exists(temp => temp.CustomerUserName == CustomerUserName) && (_customer.Exists(temp => temp.CustomerPassword == CustomerPassword)))
            {

                return null;
            }
            else
            {
                throw new CustomerException("UserName or Password is Incorrect");
            }
        }
         


        /// <summary>
        /// Method To GET The Added Details
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomer()
        {
            return GetCustomer();
        }

        /// <summary>
        /// Method To GET The Customer Details By CustomerId
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public Customer GetCustomerByCustomerId(int customerId)
        {
            Customer c = _customer.Find(temp => temp.CustomerId == customerId);
            return c;
        }

        /// <summary>
        /// Method To GET Customer Details By Customer Username
        /// </summary>
        /// <param name="customeruserName"></param>
        /// <returns></returns>
        public Customer GetCustomerByCustomerUserName(string customeruserName)
        {
            Customer c = _customer.Find(temp => temp.CustomerUserName == customeruserName);
            return c;
        }

        /// <summary>
        /// Method To UPDATE The Customer Details
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Customer customer)
        {
            Customer abc = _customer.Find(temp => temp.CustomerId == customer.CustomerId && temp.CustomerUserName == customer.CustomerUserName && temp.CustomerEmail == customer.CustomerEmail && temp.CustomerPassword == customer.CustomerPassword && temp.CustomerMobileNumber == customer.CustomerMobileNumber && temp.CustomerAadharNumber == customer.CustomerAadharNumber && temp.CustomerPanCardNumber == customer.CustomerPanCardNumber && temp.CustomerGender == customer.CustomerUserName);
            if (abc != null)
            {
                abc.CustomerId = customer.CustomerId;
                abc.CustomerUserName = customer.CustomerUserName;
                abc.CustomerEmail = customer.CustomerEmail;
                abc.CustomerPassword = customer.CustomerPassword;
                abc.CustomerMobileNumber = customer.CustomerMobileNumber;
                abc.CustomerAadharNumber = customer.CustomerAadharNumber;
                abc.CustomerPanCardNumber = customer.CustomerPanCardNumber;
                abc.CustomerGender = customer.CustomerGender;
            }
            else
            {
                throw new CustomerException("Customer Detail Does not Exist");
            }
        }

        /// <summary>
        /// Method To Delete The Added Details
        /// </summary>
        /// <returns></returns>
        public void DeleteCustomer(Customer customer)
        {
            _customer.Remove(customer);
        }

        /// <summary>
        /// Method To REMOVE Customer By Customer Id
        /// </summary>
        /// <param name="CustomerId"></param>
        public void RemoveCustomerByCustomerId(int customerId)
        {
            _customer.RemoveAll(temp => temp.CustomerId == customerId);
            SaveIntoFile();
        }

        /// <summary>
        /// Method To REMOVE Customer By Customer User Name
        /// </summary>
        /// <param name="CustomerUserName"></param>
        public void RemoveCustomerByCustomerUserName(string customeruserName)
        {
            _customer.RemoveAll(temp => temp.CustomerUserName == customeruserName);
            SaveIntoFile();
        }
    }
}*/


