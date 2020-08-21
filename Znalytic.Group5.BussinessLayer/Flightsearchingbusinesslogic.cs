//////using System;
using System.Collections.Generic;
using System;

using Znalytics.Group5.Airline.Flightsearching.DataAccessLayer;
using Znalytics.Group5.Airline.Flightsearching.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Znalytics.Group5.Airline.Flightsearching.DataAccessLayer;
using Znalytics.Group5.Airline.Flightsearching.Entities;

namespace Znalytics.Group5.Airline.FlightsearchingBussinessLayer
{
   

        public class FlightsearchingBusinessLogic
        {
            FlightsearchingDataAccessLogic _FlightsearchingDataAccessLogic;

            public FlightsearchingBusinessLogic()
            {
                _FlightsearchingDataAccessLogic = new FlightsearchingDataAccessLogic();
            }

            //Addflightname
            public void Add(FlightsearchingDataAccessLogic FlightName)
            {
                if (FlightsearchingDataAccessLogic.FlightName != null)
                {
                    _FlightsearchingDataAccessLogic.Add(FlightName);
                }
                else
                {
                    throw new Exception("flight Name can't be null");
                }
            }

            //GetAllflightNames
            public List<FlightsearchingBusinessLogic> Get()
            {
                return _FlightsearchingDataAccessLogic.Get(Flightsearching);
            }

            public void UpdateFlightName(Flightsearching FlightName)
            {
                if (Flightsearching.FlightName != null)
                {
                    _FlightsearchingDataAccessLogic.UpdateEmployee(FlightName);
                }
            }
        }
    }





//}

using Znalytics.Group5.FlightSearching.Entities;
using Znalytics.Group5.DataAccessLayer;

namespace Znalytics.Group5.BusinessLogicLayer
{
    public class FlightSearching : IFlightSearchingBusinessLogicLayer
        {
        private IFlightSearchingDataAccessLayer fdal = null;

        public FlightSearchingBusinessLogicLayer()
        {
            fdal = new FlightSearchingDataAccessLayer();
        }

        public void AddFlightSearching(FlightSearching FlightSearching)
        {
            if (FlightSearching.FlightSearching != null)
            {
                fdal.AddFlightSearching(FlightSearching);
            }
        }
    }
}

