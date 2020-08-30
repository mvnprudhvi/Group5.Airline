using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    //Interface Is Created For Customer Data Access Layer
    interface ICustomerDataAccessLayer
    {
        //Method To Add Customer Details To The List
        void AddCustomer(Customer customer);

        //Method To Get Customer Details From The List
        List<Customer> GetCustomer();

        //Method To Update Customer Details From The List
        void UpdateCustomer(Customer customer);

        //Method To Delete Customer Details To The List
        void DeleteCustomer(Customer customer);

        //Method To Remove Customer Details By Customer Id
        void RemoveCustomerByCustomerId(string customerId);

        //Method To Remove Customer Details By Customer User Name
        void RemoveCustomerByCustomerUserName(string customeruserName);

        //Method To Login To The Application
        void Login(Customer customer);

        //Method To Get Customer Details By Customer Id
        List<Customer> GetCustomerByCustomerId(string customerId);

        //Method To Get Customer Details By Customer User Name
        List<Customer> GetCustomerByCustomerUserName(string customeruserName);



    }
}
