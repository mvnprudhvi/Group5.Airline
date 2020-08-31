
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;

using System.Collections.Generic;
using System;

using Znalytics.Group5.Airline.FlightBookingModule.DataAccessLayer;
using Znalytics.Group5.Airline.FlightBookingModule.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightSearchingDataAcessLayer;
using System.Dynamic;

namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer


{
    /// <summary>
    /// This Class Represents Business Logic Layer Of flightSearching
    /// </summary>

    public class FlightSearchingbusinessLogicLayer : IFlightSearchingbusinessLogicLayer
             
        // creating object for DataAcessLayer
    
            private FlightSearchingDataAccessLayer fsdl = null;

            public FlightSearchingbusinessLogicLayer()
            {
                fsdl = new FlightSearchingDataAccessLayer();
            }
              /// <summary>
              /// This method represents adding of flightsearching details
              /// </summary>
              /// <param name="FlightName"></param>
            public void AddFlightSearching(FlightSearching flightId)
            {
                if (flightId.flightId != null)
                {
                    _flightSearchingDataAccessLayer.Add(flightId);
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
   
    public List<FlightSearching> GetFlightSearchings()
            {
                return _flightSearching;
             }

    /// <summary>
    ///  // this method represents all the updation of details of flightsearchings
    /// </summary>
    /// <param name="FlightName"></param>

   

    public void UpdateFlightSearching(FlightSearching flightId)
            {
                if (flightId.flightId != null)
                {
                    _flightSearchingDataAccessLayer.UpdateflightId(flightId);
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

