using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.AirLine.BusinessLogicLayer
{
    interface ICustomerBusinessLogicLayer
    {
        void AddCustomer(Customer c);
        void UpdateCustomer(Customer c);
        void DeleteCustomer(Customer c);
        List<Customer> GetCustomer();
        Customer GetCustomerByCustomerId(string customerId);
        Customer GetCustomerByCustomerUserName(string customeruserName);
        void RemoveCustomerByCustomerId(string CustomerId);
        void RemoveCustomerByCustomerUserName(string customeruserName);
    }
}