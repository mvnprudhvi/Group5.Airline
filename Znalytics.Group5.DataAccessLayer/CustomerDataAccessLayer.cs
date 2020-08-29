using System;
using System.Linq;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    //represents customer data access layer
    public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        //private fields
        private static List<Customer> _customer;

        static CustomerDataAccessLayer()
        {
            _customer = new List<Customer>();
        }

        //Add
        public void AddCustomer(Customer customer)
        {
                    _customer.Add(customer);
            }
                       
    
        public void Login(Customer customer)
        {
            if (_customer.Exists(temp => temp.CustomerUserName == customer.CustomerUserName) && (_customer.Exists(temp => temp.CustomerPassword == customer.CustomerPassword)))
            
            }

        public void DeleteCustomer(Customer customer)
        {
            _customer.Remove(customer);
        }

        public List<Customer> RemoveCustomerByCustomerId(string CustomerId)
        {
            return _customer;
        }

        public List<Customer> RemoveCustomerByCustomerUserName(string CustomerUserName)
        {
            return _customer;
        }

        public List<Customer> GetCustomerByCustomerId(string CustomerId)
        {
            return _customer;
        }

        public List<Customer> GetCustomerByCustomerUserName(string CustomerUserName)
        {
            return _customer;
        }

        public List<Customer> GetCustomer()
        {
            return _customer;
        }
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
        }
    }
}


