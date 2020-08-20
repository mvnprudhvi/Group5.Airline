using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public class CustomerDataAccessLayer
    {
        //private fields
        private static List<Customer> _customer = new List<Customer>();

        //Add
        public void Add(Customer customer)
        {
            _customer.Add(customer);
        }
        //Get all customer
        public List<Customer> GetCustomer()
        {
            return _customer;
        }

        //Update
        public void UpdateCustomer(Customer customer)
        {
            //updating customer username
            Customer cust = _customer.Find(temp => temp.UserName == customer.UserName);
            if (cust != null)
            {
                cust.UserName = customer.UserName;
            }
        }
    }
}
   


