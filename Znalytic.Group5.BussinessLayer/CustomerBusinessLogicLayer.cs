//Importing Statements
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.AirLine.BusinessLogicLayer;
using Znalytics.Group5.AirLine.Entities;
using System.Runtime.Serialization;

//Created a Namespace For Business Layer of Customer Module
namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    /// Represents BusinessLogic Class of Customer And Implementing An Interface
    /// </summary> 
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
         CustomerDataAccessLayer cdal;


        /// <summary>
        /// Default Constructor
        /// </summary>
        public CustomerBusinessLogicLayer()
        {
          //Creating Object For DataAcessLayer And Storing  In Reference Variable
            cdal = new CustomerDataAccessLayer();
        }

        //Method to ADD Customer Details To The List
        public void AddCustomer(Customer customer)
        {
            try
            {
                //Customer Details Should Not Be null
                if ((customer.CustomerId != null) && (customer.CustomerUserName != null) && (customer.CustomerEmail != null) && (customer.CustomerPassword != null) && (customer.CustomerMobileNumber != null) && (customer.CustomerAadharNumber != null) && (customer.CustomerPanCardNumber != null) && (customer.CustomerGender != null))
                {
                    cdal.AddCustomer(customer);
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        //Method To Login 
        public void Login(Customer customer)
        {
            //Customer User Name and Password Cannot Be null
            if (customeruserName != null && customerPassword != null)
            {
                return cdal.Login(customer);
            }
        }

        // Method to GET the Added Cutomer Details
        public List<Customer> GetCustomer()
        {
            return cdal.GetCustomer();
        }

        //Method to GET Customer Details By Customer Id
        public Customer GetCustomerByCustomerId(string customerId)
        {
            try
            {
                //Customer Id Should Not Be null
                if (customerId != null)
                {
                    return cdal.GetCustomerByCustomerId(customerId);
                }
                else
                {
                    return null;
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        //Method to GET Customer By Customer User Name
        public Customer GetCustomerByCustomerUserName(string customeruserName)
        {
            try
            {
                //Customer User Name should not be null
                if (customeruserName != null)
                {
                    return cdal.GetCustomerByCustomerUserName(customeruserName);
                }
                else
                {
                    return null;
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        //Method to Update Customer Details To The List
        public void UpdateCustomer(Customer customer)// update Customer id
        {

            try
            //Customer Id should not be null
            {
                if (customer.CustomerId != null)
                {
                    cdal.UpdateCustomer(customer);
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        //Method To Delete Customer Details
        public void DeleteCustomer(Customer customer)
        {
            cdal.DeleteCustomer(customer);
        }

        //Method to Delete Customer By Customer Id 
        public void RemoveCustomerByCustomerId(string customerId)
        {
            try
            {
                //Customer Id should not be null
                if (customerId != null)
                {
                    cdal.RemoveCustomerByCustomerId(customerId);
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        //Method to REMOVE Customer by Customer User Name
        public void RemoveCustomerByCustomerUserName(string customeruserName)
        {

            try
            {
                //Customer User Name should not be null
                if (customeruserName != null)
                {
                    cdal.RemoveCustomerByCustomerUserName(customeruserName);
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }
    }
}

        