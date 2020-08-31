
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
            public void AddFlightSearching(FlightName FlightName)
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

    /// <summary>
    ///  this method represents Getting All flightsearchings
    /// </summary>
    /// <returns></returns>
   
    public List<FlightSearching> GetFlightSearchings()
            {
                return _FlightSearchings;
    }
    /// <summary>
    ///  // this method represents all the updation of details of flightsearchings
    /// </summary>
    /// <param name="FlightName"></param>

   

    public void UpdateFlightSearching(FlightName FlightName)
            {
                if (FlightName.FlightName != null)
                {
                    _FlightSearchingDataAccessLayer.UpdateFlightName(FlightName);
                }
            }

    /// <summary>
    /// this method represents getting all details of flightName
    /// </summary>
    /// <param name="FlightName"></param>
    /// <returns></returns>
    public List<Flight> GetFlightsByFlightName(string FlightName)
       {
      return  fsdl.GetFlightName();
       }
    /// <summary>
    /// this method represents getting all details of flightid
    /// </summary>
    /// <param name="FlightId"></param>
    /// <returns></returns>
    public List<Flight> GetFlightsByFlightId(string FlightId)
       {
         return fsdl.GetFlightId);
        }
    /// <summary>
    /// this method represents getting all details of source
    /// </summary>
    /// <param name="Source"></param>
    /// <returns></returns>

    public List<FlightSchedule> GetFlightSchedulesBySource(string Source)
    
    {


        return fsdl.GetSource();
    }
    /// <summary>
    /// this method represents getting all details of destination
    /// </summary>
    /// <param name="Destination"></param>
    /// <returns></returns>

    public List<FlightSchedule> GetFlightSchedulesByDestination(string Destination)
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

