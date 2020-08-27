///'...........KEERTHANA.........

using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

/// <summary>
/// represents dataAccessLayer of Flight
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
   public class FlightScheduleDataAccessLayer
    {

        // create list
        List<FlightSchedule> _schedules = new List<FlightSchedule>();

        //Add
        public void AddSchedule(FlightSchedule flightSchedule)
        {
            _schedules.Add(flightSchedule);
        }

        //Get  FlightName
        public List<FlightSchedule> GetFlightName()
        {
            return _flights;
        }

            
     /// <summary>
     /// Delete Method with 2 parameters
     /// </summary>
     /// <param name="flightId"></param>
     /// <param name="flightName"></param>
     public void DeleteFlightFlightScheduleByflightId(int flightId ,string flightName)
        {
           _flights.RemoveAll(temp => temp.flightId == flightId && temp.flightName == flightName);
        }

        


    }
}


