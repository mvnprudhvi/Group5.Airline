using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public class CustomerDataAccessLayer
    {
        //create list
        public class customer
        {
            List<Customer> Customer = new List<Customer>();
        }

        public void AddCustomer(Customer Customer)
        {
            ////code generating new customer username
            Console.Write("enter username");
            //customers.Add(customer);
            customer.Add(customer);
            //not done

        }
    }
}

