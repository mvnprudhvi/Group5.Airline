// created by Reshma
/*using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
namespace Znalytics.Group5.Airline.FlightSearchingDataAcessLayer
{
    public interface IFlightSearchingDataAccessLayer
    {
        /// <summary>
        /// this method  add all the details of flightID
        /// </summary>
        /// <param name="FlightID"></param>
        void AddFlight(Flight flightId);
        /// <summary>
        /// this method updating all the details of flightID
        /// </summary>
        /// <param name="flightId"></param>
        void UpdateFlight(Flight flightId);

        /// <summary>
        /// this method gets all the details of flightName
        /// </summary>
        /// <param name="flightName"></param>
        /// <returns></returns>
        List<Flight> Flight(string flightName);
        /// <summary>
        /// this method gets all the details of flightId
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        List<Flight> GetFlightsByFlightId(string flightId);
        /// <summary>
        /// this method gets all the details of source
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        List<FlightSchedule> GetScheduleBySource(string source);
        /// <summary>
        /// this method gets all the details of destination
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        List<FlightSchedule> GetFlightSheduleByDestination(string destination);
    }
}
