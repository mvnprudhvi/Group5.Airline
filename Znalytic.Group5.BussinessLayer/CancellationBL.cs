using Znalytics.AirLine.CancellationBLModule.Entities;
using Znalytics.AirLine.DataAccessLayer;

namespace Znalytics.AirLine.BusinessLogicLayer
{
    public class FlightBusinessLogicLayer : FlightBusinessLogicLayer
    {
        private FlightDataAccessLayer fdal = null;

        public FlightBusinessLogicLayer()
        {
            fdal = new FlightDataAccessLayer();
        }

        public void AddFlightName(FlightName Flight)
        {
            if (Flight.FlightName != null)
       
                fdal.AddFlight(Flight);
            }
        }
    }












/*//using system.Znalytic.Group5.BussinessLayer
    public  class FlightBussinessLayer
    {
        public void AddFlight(Flight fn)
    {
        if(Flight.FlightName<=30)
        {
            FlightBussinessLayer fdl = new FlightBussinessLayer()
        }
    }
