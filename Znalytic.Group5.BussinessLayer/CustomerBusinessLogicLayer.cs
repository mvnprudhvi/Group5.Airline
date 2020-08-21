using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    //represents customer business logic layer
    public class CustomerBusinessLogicLayer
    {
        CustomerDataAccessLayer _CustomerDataAccessLayer;
        public CustomerBusinessLogicLayer()
        {
            _CustomerDataAccessLayer = new CustomerDataAccessLayer();
        }
        //add customer
        public void Add(Customer customer)
        {
            if (customer.UserName != null)
            {
                _CustomerDataAccessLayer.Add(customer);
            }
            else
            {
                throw new Exception("Username can't be null");
            }
        }
        //get customer
        public List<Customer> GetCustomers()
        {
            return _CustomerDataAccessLayer.GetCustomers();
        }
        //update customer

        public void UpdateCustomer(Customer customer)
        {
            if (customer.UserName != null)
            {
                _CustomerDataAccessLayer.UpdateCustomer(customer);
            }
        }
    }
}