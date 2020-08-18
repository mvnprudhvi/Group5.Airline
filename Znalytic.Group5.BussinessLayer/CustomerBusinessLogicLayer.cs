using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    public class CustomerBusinessLogicLayer
    {
        private CustomerDataAccessLayer cdal = null;

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

