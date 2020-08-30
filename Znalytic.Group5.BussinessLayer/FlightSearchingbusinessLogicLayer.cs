//////using System;
using System.Collections.Generic;
using System;

using Znalytics.Group5.Airline.Flightsearching.DataAccessLayer;
using Znalytics.Group5.Airline.Flightsearching.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightSearchingDataAcessLayer;

namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer


{ 

        public class FlightSearchingbusinessLogicLayer : IFlightSearchingbusinessLogicLayer()
             

    
            private FlightSearchingDataAccessLayer fdal = null;

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
            public List<FlightSearchingbusinessLogicLayer> GetFlightSearchings()
            {
                return _FlightSearchings;
            }

            public void UpdateFlightName(FlightName FlightName)
            {
                if (FlightName.FlightName != null)
                {
                    _FlightSearchingDataAccessLayer.UpdateFlightName(FlightName);
                }
            }
        public FlightSearching GetFlightSearchinsByFlightID(int FlightID)
        {
        return _FlightID;
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

