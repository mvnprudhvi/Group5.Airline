//Mvn prudhvi\\
using System;
using System.Linq;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.AirLine.Entities;

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
        /// Method To ADD Details To The List
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {

            if (!_customer.Exists(temp => temp.CustomerId == customer.CustomerId))
            {
                _customer.Add(customer);
            }
            else
            {
                throw new CustomerException("Customer id already exists");
            }
        }


        /// <summary>
        /// Method To  
        /// </summary>
        /// <returns></returns>
        public void Login(Customer customer)
        {
            if (_customer.Exists(temp => temp.CustomerUserName == customer.CustomerUserName) && (_customer.Exists(temp => temp.CustomerPassword == customer.CustomerPassword)))
            {
                _customer.Login(customer);
            }
            else
            {
                throw new CustomerException("UserName or Password is Incorrect");
            }
        }
        public List<Customer> Login(Customer customer)
        {
            return _customer;

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
        public Customer GetCustomerByCustomerId(string customerId)
        {
            Customer c = _customer.Find(temp => temp.CustomerId == Customer.customerId);
            return c;
        }

        /// <summary>
        /// Method To GET Customer Details By Customer Username
        /// </summary>
        /// <param name="customeruserName"></param>
        /// <returns></returns>
        public Customer GetCustomerByCustomerUserName(string customeruserName)
        {
            Customer c = _customer.Find(temp => temp.CustomerUserName == Customer.customeruserName);
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
        public void RemoveCustomerByCustomerId(string customerId)
        {
            _customer.RemoveAll(temp => temp.CustomerId == Customer.customerId);
        }

        /// <summary>
        /// Method To REMOVE Customer By Customer User Name
        /// </summary>
        /// <param name="CustomerUserName"></param>
        public void RemoveCustomerByCustomerUserName(string customeruserName)
        {
            _customer.RemoveAll(temp => temp.CustomerUserName == Customer.customeruserName);
        }
    }
}


