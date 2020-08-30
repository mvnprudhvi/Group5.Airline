
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;

using System.Collections.Generic;
using System;

using Znalytics.Group5.Airline.Flightsearching.DataAccessLayer;
using Znalytics.Group5.Airline.Flightsearching.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightSearchingDataAcessLayer;
using System.Dynamic;

namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer


{ 

        public class FlightSearchingbusinessLogicLayer : IFlightSearchingbusinessLogicLayer
             

    
            private FlightSearchingDataAccessLayer fsdl = null;

            public FlightSearchingbusinessLogicLayer()
            {
                fsdl = new FlightSearchingDataAccessLayer();
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
            public List<FlightSearching> GetFlightSearchings()
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
         public   List<Flight> GetFlightsByFlightName(string FlightName)
       {
      return  fsdl.GetFlightName();
    }
         public List<Flight> GetFlightsByFlightId(string FlightId)
       {
         return fsdl.GetFlightId);
    }

    public List<FlightSchedule> GetFlightScheduleBySource(string Source)
    
    {


        return fsdl.GetSource();
    }
    

public List<FlightSchedule> GetFlightScheduleByDestination(string Destination)
    {
        return fsdl.GetDestination();
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

