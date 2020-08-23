///'KEERTHANA...

using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

/// <summary>
/// represents dataAccessLayer of Flight
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
   public class FlightDetailsDataAccessLogic
    {

        // create list
        private static List<FlightDetail> _flights = new List<FlightDetail>();

        //Add
        public void AddflightName(FlightDetail fname)
        {
            _flights.Add(fname);
        }

        //Get  FlightName
        public List<FlightDetail> GetFlightName()
        {
            return _flights;
        }

            
     /// <summary>
     /// Delete Method with 2 parameters
     /// </summary>
     /// <param name="flightId"></param>
     /// <param name="flightName"></param>
     public void DeleteFlightDetailByflightId(int flightId,string flightName)
        {
           _flights.RemoveAll(temp => temp.flightId == flightId && temp.flightName == flightName);
        }

        


    }
}


