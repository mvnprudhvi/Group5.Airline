using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

/// <summary>
/// represents dataAccessLayer for Flight
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
   public class FlightDetailsDataAccessLogic
    {

        // create list
        private static List<FlightDetail> _flights = new List<FlightDetail>();

        //Add
        public void AddFlightDetail(FlightDetail flight)
        {
            _flights.Add(flight);
        }

        //Get all FlightDetails
        public List<FlightDetail> GetFlightDetails()
        {
            return _flights;
        }


        //Search details of flight using find()
        public void SearchFlightDetailsBySource(string source, string flightName)
        {
         //Get matching flights based on flightId
            FlightDetail fd = _flights.Contains(temp => temp.source == flight.source);
            if (fd != null)
            {
                fd.flightName = flight.flightName;
            }
        }      

        //
            
     /// <summary>
     /// Delete Method with 2 parameters
     /// </summary>
     /// <param name="flightId"></param>
     /// <param name="flightName"></param>
     public void DeleteFlightDetailByflightId(string flightId,string flightName)
        {
           _flights.RemoveAll(temp => temp.flightId == flightId && temp.flightName == flightName);
        }

        public void Add(FlightDetail flight)


    }
}
