using Znalytics.AirLine.CancellationBLModule.Entities;
using Znalytics.AirLine.DataAccessLayer;

namespace Znalytics.AirLine.BusinessLogicLayer
{
    public class CancellationBusinessLogicLayer : ICancellationBusinessLogicLayer
    {
        private ICancellationDataAccessLayer cdal = null;

        public CancellationBusinessLogicLayer()
        {
            cdal = new CancellationDataAccessLayer();
        }

        public void AddFlightName(FlightName FlightName)
        {
            if (FlightName.FlightName != null)
       
                cdal.AddFlightName(FlightName);
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
