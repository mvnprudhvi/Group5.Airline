using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    //represents customer business logic layer 
    public class CustomerBusinessLogicLayer
    {
        CustomerDataAccessLayer  _customerDataAccessLayer;

        public CustomerBusinessLogicLayer()
        {
            _customerDataAccessLayer  = new CustomerDataAccessLayer();
                }
        public void AddCustomer(Customer customer)
            {
                if ((customer.CustomerId != 0) && (customer.CustomerUserName != null) && (customer.CustomerEmail != null) && (customer.CustomerPassword != null) && (customer.CustomerMobileNumber != null) && (customer.CustomerAadharNumber != null) && (customer.CustomerPanCardNumber != null) && (customer.CustomerGender != null))
                {
                    _customerDataAccessLayer.AddCustomer(customer);
                }
            }
            public void DeleteCustomer(Customer customer)
            {
                if ((customer.CustomerId != 0) && (customer.CustomerUserName != null) && (customer.CustomerEmail != null) && (customer.CustomerPassword != null) && (customer.CustomerMobileNumber != null) && (customer.CustomerAadharNumber != null) && (customer.CustomerPanCardNumber != null) && (customer.CustomerGender != null))
                {
                    _customerDataAccessLayer.DeleteCustomer(customer);
                }
            }
            public List<Customer> GetCustomer()
            {
                return _customerDataAccessLayer.GetCustomer();
            }
        public void UpdateCustomer(Customer customer)
        {
            if ((customer.CustomerUserName != null) || (customer.CustomerEmail != null) || (customer.CustomerPassword != null) || (customer.CustomerMobileNumber != null) || (customer.CustomerAadharNumber != null) || (customer.CustomerPanCardNumber != null) || (customer.CustomerGender != null))
            {
                _customerDataAccessLayer.UpdateCustomer(customer);
            }
        }
            public Customer GetCustomerByCustomerId(int CustomerId)
            {
                return _customerDataAccessLayer.GetCustomerByCustomerId(CustomerId);

            }
        }
    }
        