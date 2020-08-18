//
///

namespace Znalytic.Group5.Airline.FlightSearchingModule.BussinessLayer
{
    class FlightSearchingBusinessLogic
    {
        public class FlightSearchingBusinessLogicLayer : IFlightSearchingBusinessLogicLayer
        {
            private IFlightSearchingDataAccessLayer fdal = null;
            
            public FlightSearchingBusinessLogicLayer()
            {
                fdal = new FlightSearchingDataAccessLayer();
            }

            public void AddFlightName(FlightName FlightName)
            {
                if (FlightName.FlightName != null)

                    fdal.AddFlightName(FlightName);
            }
        }
    }


}
}
