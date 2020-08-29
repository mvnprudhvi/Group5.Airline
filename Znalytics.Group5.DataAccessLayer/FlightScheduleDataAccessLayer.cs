///'...........KEERTHANA.........

//Impoting Statements
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;

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

        //Method to ADD Schedules to the list
        public void AddSchedule(FlightSchedule schedule)
        {
            //Condition to check whether the flightId exists or not
            if (!_scheduleList.Exists(temp => temp.flightId == schedule.flightId))
            {
                _scheduleList.Add(schedule);
            }
            else
            {
                throw new Exception("flight id doesnot exist");
            }
        }

        // Method to GET the added Schedules
        public List<FlightSchedule> GetSchedule()
        {
            return _scheduleList;
        }

        //Method to GET the Schedules by flightScheduleId
        public List<FlightSchedule> GetScheduleByFlightScheduleId(string flightScheduleId)
        {

            return _scheduleList.FindAll(temp => temp.FlightScheduleId == flightScheduleId);

        }



        //Method to GET schedules  by Source
        public List<FlightSchedule> GetScheduleBySource(string source)
        {

            return _scheduleList.FindAll(temp => temp.Source == source);

        }

        //Method to GET schedules  by Destination
        public List<FlightSchedule> GetScheduleByDestination(string destination)
        {

            return _scheduleList.FindAll(temp => temp.Destination == destination);

        }

        //Method to UPDATE source of Flight
        public void UpdateSource(FlightSchedule schedule)// update source of a flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.flightScheduleId == schedule.flightScheduleId);
            if (fs != null)
            {
                fs.Source = schedule.Source;


            }
        }

        //Method to UPDATE Destinantion of Flight
        public void UpdateDestination(FlightSchedule schedule)// update Destination of flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.flightScheduleId == schedule.flightScheduleId);
            if (fs != null)
            {
                fs.Destination = schedule.Destination;


            }
        }

        //method to UPDATE DepartureTiming of flight
        public void UpdateDepartureTiming(FlightSchedule schedule)// update Destination of flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.flightScheduleId == schedule.flightScheduleId);
            if (fs != null)
            {
                fs.DepartureTiming = schedule.DepartureTiming;


            }
        }

        //method to UPDATE ArrivalTiming of flight
        public void UpdateArrivalTiming(FlightSchedule schedule)// update Destination of flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.ArrivalTiming = schedule.ArrivalTiming;


            }
        }

        //Method to REMOVE  schedule of the flight by flightId
        public void RemoveFlightByFlightId(string flightId)
        {

            _scheduleList.RemoveAll(temp => temp.FlightId == flightId);

        }

        //Method to REMOVE schedule of the flight by flightScheduleId
        public void RemoveFlightByFlightScheduleId(string flightScheduleId)
        {

            _scheduleList.RemoveAll(temp => temp.FlightScheduleId == flightScheduleId);

        }
    }
}











