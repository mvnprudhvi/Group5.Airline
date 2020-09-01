// created by Reshma

using System;
namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer
{
    public interface IFlightSearchingbusinessLogicLayer
    {/// <summary>
    /// this method represents adding of flightName
    /// </summary>
    /// <param name="FlightName"></param>
        void Add(FlightName FlightName);
        /// <summary>
        /// this method represents getting of all flightsearching
        /// </summary>
        /// <returns></returns>
        List<FlightSearching> GetFlightSearchings();
        /// <summary>
        /// this method represents getting all of flightName
        /// </summary>
        /// <param name="FlightName"></param>
        /// <returns></returns>
        List<Flight> GetFlightsByFlightName(string FlightName);
        /// <summary>
        /// this method represents getting all of flightId
        /// </summary>
        /// <param name="FlightId"></param>
        /// <returns></returns>
        List<Flight> GetFlightsByFlightId(string FlightId);
        /// <summary>
        /// this method represents getting all of source details
        /// </summary>
        /// <param name="Source"></param>
        /// <returns></returns>
        List<FlightSchedule> GetFlightSchedulesBySource(string Source);
        /// <summary>
        /// this method represents getting all of destination details
        /// </summary>
        /// <param name="Destination"></param>
        /// <returns></returns>
        List<FlightSchedule> GetFlightSchedulesByDestination(string Destination);



    }
}
