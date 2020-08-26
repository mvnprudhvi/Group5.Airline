//////using System;
using System.Collections.Generic;
using System;

using Znalytics.Group5.Airline.Flightsearching.DataAccessLayer;
using Znalytics.Group5.Airline.Flightsearching.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer


{ 

        public class FlightSearchingbusinessLogicLayer : IFlightSearchingbusinessLogicLayer
             

    
            private IFlightSearchingDataAccessLayer fdal = null;

            public FlightSearchingbusinessLogicLayer()
            {
                fdal = new FlightSearchingDataAccessLayer();
            }
              //Addflightname
            public void Add(FlightName FlightName)
            {
                if (FlightName.FlightName != null)
                {
                    _FlightSearchingDataAccessLayer.Add(FlightName);
                }
                else
                {
                    throw new Exception("flight Name can't be null");
                }
            }

            //GetAllflightNames
            public List<FlightSearchingbusinessLogicLayer> Get()
            {
                return _FlightSearchingDataAccessLayer.Get(FlightName);
            }

            public void UpdateFlightName(FlightName FlightName)
            {
                if (FlightName.FlightName != null)
                {
                    _FlightSearchingDataAccessLayer.UpdateFlightName(FlightName);
                }
            }
        }
    }







/*using Znalytics.Group5.FlightSearching.Entities;
using Znalytics.Group5.DataAccessLayer;

namespace Znalytics.Group5.BusinessLogicLayer
{
    public class FlightSearchingBusinessLogicLayer : IFlightSearchingBusinessLogicLayer
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
}*/

