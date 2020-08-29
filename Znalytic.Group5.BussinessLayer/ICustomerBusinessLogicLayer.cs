using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.AirLine.IBusinessLogicLayer
{
    interface ICustomerBusinessLogicLayer
    {
        void AddCustomer(Customer c);
        void UpdateCustomer(Customer c);
        void DelCustomer(Customer c);
        Customer GetCustomerById(int CustomerId);
    }
}