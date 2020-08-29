using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.AirLine.ICustomerBusinessLogicLayer
{
    interface ICustomerBusinessLogicLayer
    {
        void AddCustomer(Customer c);
        void UpdateCustomer(Customer c);
        void DeleteCustomer(Customer c);
        void Getustomer(Customer c);
        public List<Customer> GetCustomerByCustomerId(string CustomerId);
        public List<Customer> GetCustomerByCustomerUserName(string CustomerUserName);
        void RemoveCustomerByCustomerId(string CustomerId);
        void RemovecustomerByCustomerUserName(string CustomerUserName);
    }
}