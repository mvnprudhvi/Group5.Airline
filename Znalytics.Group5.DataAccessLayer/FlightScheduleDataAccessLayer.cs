//'...........KEERTHANA...........

//Impoting Statements
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

/// <summary>
/// represents dataAccessLayer of Flight
/// </summary>
namespace Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer
{
    /// <summary>
    /// Represents the class for Flight Schedule
    /// </summary>
    public class FlightScheduleDataAccessLayer : IFlightScheduleDataAccessLayer
    {
        //Created a list for flight Schedule
        private static List<FlightSchedule> _scheduleList
        {
            set;
            get;
        }


        //Static Constructor
        static FlightScheduleDataAccessLayer()
        {
            _scheduleList = new List<FlightSchedule>()
            {
                //Sample information
                new FlightSchedule() { flightId = "FID1011", FlightScheduleId = "FSID01", Source = "HYDERABAD", Destination = "MUMBAI", DepartureTiming = "01-09-2020  06:30:00 AM", ArrivalTiming = "01-09-2020  06:00:00 AM" },
                new FlightSchedule() { flightId = "FID1022", FlightScheduleId = "FSID02", Source = "MUMBAI", Destination = "CHENNAI", DepartureTiming = "02/09/2020 06:30:00 AM", ArrivalTiming = "01-09-2020  06:00:00 AM" },
                new FlightSchedule() { flightId = "FID1033", FlightScheduleId = "FSID03", Source = "BANGALORE", Destination = "DELHI", DepartureTiming = "05/10/2020  05:30:25 PM", ArrivalTiming = "01-09-2020  05:00:00 AM" },
                new FlightSchedule() { flightId = "FID1044", FlightScheduleId = "FSID04", Source = "HYDERABAD", Destination = "DELHI", DepartureTiming = "06/10/2020 08:15:10 AM", ArrivalTiming = "01-09-2020  08:00:00 AM" },
                new FlightSchedule() { flightId = "FID1022", FlightScheduleId = "SFSID02", Source = "HYDERABAD", Destination = "BANGALORE", DepartureTiming = "02/09/2020 11:50:44AM", ArrivalTiming = "01-09-2020  10:45:00 AM" }
            };
        }

        /// <summary>
        /// Method to ADD Schedules to the list
        /// </summary>
        /// <param name="schedule"></param>
        public void AddSchedule(FlightSchedule schedule)
        {
            //Condition to check whether the flightId exists or not
            if (!_scheduleList.Exists(temp => temp.flightId == schedule.flightId))
            {
                _scheduleList.Add(schedule);
            }
            else
            {
                throw new Exception("flight Id doesnot exist");
            }
        }

        /// <summary>
        ///  // Method to GET the added Schedules
        /// </summary>
        /// <returns></returns>
        public List<FlightSchedule> GetSchedule()
        {
            return _scheduleList;
        }

        /// <summary>
        /// //Method to GET the Schedules by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleByFlightScheduleId(string flightScheduleId)
        {

            return _scheduleList.FindAll(temp => temp.FlightScheduleId == flightScheduleId);

        }


        /// <summary>
        /// //Method to GET Source by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetSourceByFlightScheduleId(string flightScheduleId)
        {

            return _scheduleList.FindAll(temp => temp.FlightScheduleId == flightScheduleId);

        }

        /// <summary>
        /// //Method to GET Destination by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetDestinationByFlightScheduleId(string flightScheduleId)
        {

            return _scheduleList.FindAll(temp => temp.FlightScheduleId == flightScheduleId);

        }



        /// <summary>
        /// //Method to GET the Schedules by flightI
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleByFlightId(string flightId)
        {

            return _scheduleList.FindAll(temp => temp.FlightId == flightId);

        }


        /// <summary>
        /// //Method to GET schedules  by Source
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleBySource(string source)
        {

            return _scheduleList.FindAll(temp => temp.Source == source);

        }

        /// <summary>
        /// Method to GET schedules  by Destination
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleByDestination(string destination)
        {

            return _scheduleList.FindAll(temp => temp.Destination == destination);

        }

        /// <summary>
        /// //Method to UPDATE source of Flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateSource(FlightSchedule schedule)
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.Source = schedule.Source;


            }
            else
            {
              
             throw new FlightException("FlightScheduleId doesn't exist");
            }
        }


        /// <summary>
        /// Method to UPDATE Destinantion of Flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateDestination(FlightSchedule schedule)
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.Destination = schedule.Destination;


            }
            else
            {

                throw new FlightException("FlightScheduleId doesn't exist");
            }
        }

        /// <summary>
        /// method to UPDATE DepartureTiming of flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateDepartureTiming(FlightSchedule schedule)// update Destination of flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.DepartureTiming = schedule.DepartureTiming;


            }
           
        }

        /// <summary>
        /// /method to UPDATE ArrivalTiming of flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateArrivalTiming(FlightSchedule schedule)// update Destination of flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.ArrivalTiming = schedule.ArrivalTiming;


            }
        }

        
        /// <summary>
        // Method to REMOVE  schedule of the flight by flightId
        /// </summary>
        /// <param name="flightId"></param>
        public void RemoveFlightScheduleByFlightId(string flightId)
        {
            //Condition to check whether the flightId exists or not
           if( _scheduleList.Exists(temp => temp.FlightId == flightId))
            {
                _scheduleList.RemoveAll(temp => temp.FlightId == flightId);
            }
           else
            {
                throw new FlightException("flight id doesn't exist");
            }

        }

        /// <summary>
        /// Method to REMOVE schedule of the flight by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        public void RemoveFlightScheduleByFlightScheduleId(string flightScheduleId)
        {
            //Condition to check whether the flightId exists or not
           if( _scheduleList.Exists(temp => temp.FlightScheduleId == flightScheduleId))
            {
                _scheduleList.RemoveAll(temp => temp.FlightScheduleId == flightScheduleId);
            }
            else
            {
                throw new FlightException("flight id doesn't exist");
            }

        }
    }
}











