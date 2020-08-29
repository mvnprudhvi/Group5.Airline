using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.AirLine.ICustomerBusinessLogicLayer;

//Created a Namespace For Business Layer of Customer Module
namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    /// Represents BusinessLogic class of Customer and Implementing an interface
    /// </summary> 
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
        private CustomerDataAccessLayer cdal;


        /// <summary>
        /// Default Constructor
        /// </summary>
        public CustomerBusinessLogicLayer()
        {
            CustomerDataAccessLayer cdal = new CustomerDataAccessLayer();
        }

        //Method to ADD Customer Details To The List
        public void AddCustomer(Customer customer)
        {
            if ((customer.CustomerId != 0) && (customer.CustomerUserName != null) && (customer.CustomerEmail != null) && (customer.CustomerPassword != null) && (customer.CustomerMobileNumber != null) && (customer.CustomerAadharNumber != null) && (customer.CustomerPanCardNumber != null) && (customer.CustomerGender != null))
            {
                cdal.AddCustomer(customer);
            }
        }

        //Method to Delete Customer Details To The List
        public void DeleteCustomer(Customer customer)
        {
            if ((customer.CustomerId != 0) && (customer.CustomerUserName != null) && (customer.CustomerEmail != null) && (customer.CustomerPassword != null) && (customer.CustomerMobileNumber != null) && (customer.CustomerAadharNumber != null) && (customer.CustomerPanCardNumber != null) && (customer.CustomerGender != null))
            {
                cdal.DeleteCustomer(customer);
            }
        }


        //Method to Update Customer Details To The List
        public void UpdateCustomer(Customer customer)
        {
            if ((customer.CustomerUserName != null) || (customer.CustomerEmail != null) || (customer.CustomerPassword != null) || (customer.CustomerMobileNumber != null) || (customer.CustomerAadharNumber != null) || (customer.CustomerPanCardNumber != null) || (customer.CustomerGender != null))
            {
                cdal.UpdateCustomer(customer);
            }
        }

        //Method to Get Customer By Customer ID Details To The List
        public List<Customer> GetCustomer()
        {
            return cdal.GetCustomer();
        }

            public List<Customer> GetCustomerByCustomerId(string Customer);
            {
                return cdal.GetCustomerByCustomerId(Customer);
            }
        }
    }
}

        