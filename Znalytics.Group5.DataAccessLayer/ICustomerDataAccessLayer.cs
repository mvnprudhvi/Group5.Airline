using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    interface ICustomerDataAccessLayer
    {
        void AddCustomer(Customer customer);
        List<Customer> GetCustomer();
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        List<Customer> RemoveCustomerByCustomerId(string CustomerId);
        List<Customer> RemoveCustomerByCustomerUserName(string CustomerUserName);
        void Login(Customer customer);
       List<Customer> GetCustomerByCustomerId(string CustomerId);
        List<Customer> GetCustomerByCustomerUserName(string CustomerUserName);



    }
}
