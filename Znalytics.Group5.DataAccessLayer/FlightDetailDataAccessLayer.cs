using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.FlightsModule.Entities;
/// <summary>
/// represents dataAccessLayer for Flight
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
   public class FlightDetailDataAccessLayer
    {

        //create list

         List<FlightDetail> listOfFlights = new List<FlightDetail>();


        /// <summary>
        /// Adding new flight Details
        /// </summary>
        /// <param name="flight">Attribute to add new flight</param>
        public void AddFlight(FlightDetail flight)
        {
            listOfFlights.Add(flight);
        }
            
     /// <summary>
     /// Delete Method with 2 parameters
     /// </summary>
     /// <param name="flightId"></param>
     /// <param name="flightName"></param>
     public void DeleteFlightDetailByflightId(string flightId,string flightName)
        {
            listOfFlights.RemoveAll(temp => temp.flightId == flightId && temp.flightName == flightName);
        }

        public void UpdateToList( string source, string destination)
        {
            listOfFlights.
        }
            
            
        
    }
}
