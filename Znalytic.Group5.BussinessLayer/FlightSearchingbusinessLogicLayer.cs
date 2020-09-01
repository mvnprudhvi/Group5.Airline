// created by Reshma
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
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer;
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer;

namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer


{
    /// <summary>
    /// This Class Represents Business Logic Layer Of flightSearching
    /// </summary>

    public class FlightSearchingbusinessLogicLayer : IFlightSearchingbusinessLogicLayer

        // creating object for DataAcessLayer
        FlightScheduleDataAccessLayer fsdl = new FlightScheduleDataAccessLayer();

    

            public FlightSchedulebusinessLogicLayer()
            {
        FlightScheduleDataAccessLayer fsdl = new FlightScheduleDataAccessLayer();
            }
              /// <summary>
              /// This method represents adding of flightsearching details
              /// </summary>
              /// <param name="FlightName"></param>
            public void AddFlight(string flightId)
            {
                if (flightId.FlightId != null)
                {
                    fsdl.Add(flightId);
                }
                else
                {
                    throw new Exception("flight Id can't be null");
                }
            }

    /// <summary>
    ///  this method represents Getting All flightsearchings
    /// </summary>
    /// <returns></returns>
   
    public List<Flight> GetFlightSearchings()
            {
                return _flight;
             }

    /// <summary>
    ///  // this method represents all the updation of details of flightsearchings
    /// </summary>
    /// <param name="FlightName"></param>

   

    public void UpdateFlight(string  flightId)
            {
                if (flightId.FlightId != null)
                {
                   fsdl.UpdateflightId(flightId);
                }
            }

    /// <summary>
    /// this method represents getting all details of flightName
    /// </summary>
    /// <param name="FlightName"></param>
    /// <returns></returns>
    public List<Flight> GetFlightsByFlightName(string flightName)
       {
      return  fsdl.GetflightName();
       }
    /// <summary>
    /// this method represents getting all details of flightid
    /// </summary>
    /// <param name="FlightId"></param>
    /// <returns></returns>
    public List<Flight> GetFlightsByFlightId(string flightId)
       {
         return fsdl.GetflightId();
        }
    /// <summary>
    /// this method represents getting all details of source
    /// </summary>
    /// <param name="Source"></param>
    /// <returns></returns>

    public List<FlightSchedule> GetFlightSchedulesBySource(string source)
    
    {


        return fsdl.Getsource();
    }
    /// <summary>
    /// this method represents getting all details of destination
    /// </summary>
    /// <param name="Destination"></param>
    /// <returns></returns>

    public List<FlightSchedule> GetFlightSchedulesByDestination(string destination)
    {
        return fsdl.Getdestination();
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

