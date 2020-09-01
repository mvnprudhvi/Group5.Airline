/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    interface IFlightScheduleDataAccessLayer
    {   
        /// <summary>
        /// method to add flightschedule
        /// </summary>
        /// <param name="schedule"></param>
        void AddSchedule(FlightSchedule schedule);


        /// <summary>
        /// method to remove flightSchedule by flightId
        /// </summary>
        /// <param name="flightId"></param>
        void RemoveFlightScheduleByFlightId(string flightId);

       /// <summary>
       /// method to remove flightSchedule by ScheduleId
       /// </summary>
       /// <param name="flightScheduleId"></param>
        void RemoveFlightScheduleByFlightScheduleId(string flightScheduleId);
        
           

    }
}

        
