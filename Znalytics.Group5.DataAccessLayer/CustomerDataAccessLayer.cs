using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public class CustomerDataAccessLayer
    {
        //private fields
        private static List<Customer> customer = new List<Customer>();

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
        public void UpdateCustomer(Customer employee)
        {
            //updating customer username
            Customer customer = _customer.Find(temp => temp._userName == customer._userName);
            if (customer != null)
            {
                return _userName;
            }
        }
    }
}
   


