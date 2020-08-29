using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.AirLine.ICustomerBusinessLogicLayer;
using System.Runtime.Serialization;

//Created a Namespace For Business Layer of Customer Module
namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    /// Represents BusinessLogic class of Customer and Implementing an interface
    /// </summary> 
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
         CustomerDataAccessLayer cdal;


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
            try
            {
                if ((customer.CustomerId != null) && (customer.CustomerUserName != null) && (customer.CustomerEmail != null) && (customer.CustomerPassword != null) && (customer.CustomerMobileNumber != null) && (customer.CustomerAadharNumber != null) && (customer.CustomerPanCardNumber != null) && (customer.CustomerGender != null))
                {
                    cdal.AddCustomer(customer);
                }
            }
            catch (CustomerExcepion ex)
            {
                throw new CustomerException(ex.Message);
            }
        }

        // Method to GET the added details
        public List<Customer> GetCustomer()
        {
            return cdal.GetCustomer();
        }

        //Method to GET flightDetails by flightId
        public Customer  GetCustomerByCustomerId(string CustomerId)
        {
            try
            {
                //flight Id should not be null
                if (CustomerId != null)
                {
                    return cdal.GetCustomerByCustomerId(CustomerId);
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
        public Customer GetCustomerByCustomerUserName(string CustomerUserName)
        {
            try
            {
                //flight Id should not be null
                if (CustomerUserName != null)
                {
                    return cdal.GetCustomerByCustomerUserName(string CustomerUserName);
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

        