//Importing Statements
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.AirLine.ICustomerBusinessLogicLayer;
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

        // Method to GET the Added Cutomer Details
        public List<Customer> GetCustomer(Customer c)
        {
            return cdal.GetCustomer();
        }

        //Method to GET Customer Details By Customer Id
        public List<Customer> GetCustomerByCustomerId(string customerId)
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

        //Method to GET flightDetails by flightId
        public List<Customer> GetCustomerByCustomerUserName(string customeruserName)
        {
            try
            {
                //flight Id should not be null
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

        public void DeleteCustomer(Customer customer)
        {
            cdal.DeleteCustomer(customer);
        }

        public void Login(Customer customer)
        {
             cdal.Login(customer);
        }

        //Method to Delete Customer Details To The List
        public void RemoveCustomerByCustomerId(string CustomerId)
        {
            try
            {
                //Customer Id should not be null
                if (CustomerId != null)
                {
                    cdal.RemoveCustomerByCustomerId(CustomerId);
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        //Method to REMOVE Customer  by flightName
        public void RemoveCustomerByCustomerUserName(string CustomerUserName)
        {

            try
            {
                //flight Name should not be null
                if (CustomerUserName != null)
                {
                    cdal.RemoveCustomerByCustomerUserName(CustomerUserName);
                }
            }
            catch (CustomerException ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        //Method to Update Customer Details To The List
        public void UpdateCustomer(Customer customer)// update flightid
        {

            try
            //WareHouse Id should not be null
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


    }
}

        