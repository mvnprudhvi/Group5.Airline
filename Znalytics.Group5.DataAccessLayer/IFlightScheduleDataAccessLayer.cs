using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

namespace Znalytics.Group5.DataAccessLayer
{
    interface IFlightScheduleDataAccessLayer
    {

        /// <summary>
        /// Represents the class for WareHouse Address
        /// </summary>
        public class FlightScheduleDataAccessLayer//: FlightScheduleDataAccessLayer
        {
            //Created a list for FlightSchedule 
            private static List<FlightSchedue> _scheduleList
            {
                set;
                get;
            }

            //Static Constructor
            static FlightScheduleDataAccessLayer()
            {
                _scheduleList = new List<FlightSchedule>();

            }
        }
    }
