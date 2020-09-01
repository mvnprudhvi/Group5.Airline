// created by Reshma

using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer
{
    public interface IFlightSearchingbusinessLogicLayer
    {/// <summary>
     /// this method represents adding of flightName
     /// </summary>
     /// <param name="FlightId"></param>
     
      void AddFlight(string  flightId);
        /// <summary>
        /// this method represents  getting all of flightName
        /// </summary>
        /// <returns></returns>

        List<Flight> GetFlightSearchings();
        // this method represents getting all details
        void UpdateFlight(string flightId);
           
       
        /// <summary>
        /// this method represents getting all of flightName
        /// </summary>
        /// <param name="FlightName"></param>
        /// <returns></returns>
        /// 
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
