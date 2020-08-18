using System.Collections.Generic;
using Znalytics.Flight.CancellationModule.Entities;
using Znalytics.Group5.DataAccessLayer;

namespace Znalytics.OnlineShopping.DataAccessLayer
{
    public class FlightDataAccessLayer : FlightDataAccessLayer
    {
        //create list
        List<FlightName> FlightName = new List<FlightName>();

        public void AddFlightName(FlightName FlightName)
        {
            ////code generating new customer id

            //customers.Add(customer);

            //not done
        }
    }
}













/*using System.Collections.Generic;

namespace Znalytics.Group5.DataAccessLayer
{
    public class FlightDataLayer
    {
        private List<Flight>Flight
            public FlightDataLayer()
        {
            Flight = new List<Flight>();
        }
        public void AddFlight(Flight Flight)
        {
            Flight.Add(Flight);
        }
    }
}*/
