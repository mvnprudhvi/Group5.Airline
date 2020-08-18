//////using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytic.Group5.BussinessLayer
{
    class Flightsearchingbusinesslogic
    {



    }
//}

using Znalytics.OnlineShopping.CustomersModule.Entities;
using Znalytics.OnlineShopping.DataAccessLayer;

namespace Znalytics.OnlineShopping.BusinessLogicLayer
{
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
        private ICustomerDataAccessLayer cdal = null;

        public CustomerBusinessLogicLayer()
        {
            cdal = new CustomerDataAccessLayer();
        }

        public void AddCustomer(Customer customer)
        {
            if (customer.CustomerName != null)
            {
                cdal.AddCustomer(customer);
            }
        }
    }
}

