﻿//........KEERTHANA....
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer;
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;
//Created a namespace for BusinessLogicLayer of FlightSchedule module
namespace Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer
{
    /// <summary>
    /// Represents BusinessLogic class of FlightSchedule
    /// </summary>
    public class FlightScheduleBusinessLogicLayer : IFlightScheduleBusinessLogicLayer
    {

        //Created an object for DataAccessLayer and strore the object in reference variable
        FlightScheduleDataAccessLayer fsdl = new FlightScheduleDataAccessLayer();

        public bool checkFlightScheduleId(string flightScheduleId)
        {
            List<FlightSchedule> _ScheduleList = new List<FlightSchedule>();
            // Flight flight = new Flight();
            bool result = _ScheduleList.Exists(temp => temp.flightScheduleId == flightScheduleId);
            return result;
        }

        //Method to ADD Flights Schedule to the list
        public void AddSchedule(FlightSchedule schedule)
        {

            try
            {
                //flightScheduleIdId should not be null
                if (schedule.FlightScheduleId != null)
                {


                    fsdl.AddSchedule(schedule);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("flightScheduleId already exists");
            }
        }
        /// <summary>
        /// Method to GET the added  Schedules 
        /// </summary>
        /// <returns></returns>
        public List<FlightSchedule> GetSchedule()
        {
            return fsdl.GetSchedule();
        }


        /// <summary>
        ///Method to GET flight Schedule by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleByFlightScheduleId(string flightScheduleId)
        {
            return fsdl.GetScheduleByFlightScheduleId(flightScheduleId);
        }

        /// <summary>
        /// Method to GET flightSchedule by flightId
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleByFlightId(string flightId)
        {
            return fsdl.GetScheduleByFlightId(flightId);
        }


        /// <summary>
        /// Method to GET FlightSchedule by Source
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleBySource(string source)
        {
            return fsdl.GetScheduleBySource(source);
        }


        /// <summary>
        /// Method to GET FlightSchedule by Destination
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleByDestination(string destination)
        {
            return fsdl.GetScheduleByDestination(destination);
        }

        /// <summary>
        ///  method to Get Source by FlightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetSourceByFlightScheduleId(string flightScheduleId)
        {
            return fsdl.GetSourceByFlightScheduleId(flightScheduleId);
        }


        /// <summary>
        ///  method to Get Destination by FlightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetDestinationByFlightScheduleId(string flightScheduleId)
        {
            return fsdl.GetDestinationByFlightScheduleId(flightScheduleId);
        }


        //Method to UPDATE source of flightSchedule
        public void UpdateSource(FlightSchedule schedule)
        {

            if (schedule.FlightScheduleId != null)
            {
                fsdl.UpdateSource(schedule);
            }
        }

        //Method to UPDATE Destination of flightSchedule
        public void UpdateDestination(FlightSchedule schedule)
        {

            if (schedule.FlightScheduleId != null)
            {
                fsdl.UpdateDestination(schedule);//UpdateDepartureTiming
            }
        }
        /// <summary>
        /// Method to UPDATE DepartureTiming of flightSchedule
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateDepartureTiming(FlightSchedule schedule)
        {

            if (schedule.FlightScheduleId != null)
            {
                fsdl.UpdateDepartureTiming(schedule);
            }
        }

        /// <summary>
        /// Method to UPDATE DepartureTiming of flightSchedule
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateArrivalTiming(FlightSchedule schedule)
        {

            if (schedule.FlightScheduleId != null)
            {
                fsdl.UpdateArrivalTiming(schedule);
            }
        }
        /// <summary>
        /// Method to REMOVE flight by flightId
        /// </summary>
        /// <param name="flightId"></param>
        public void RemoveFlightScheduleByFlightId(string flightId)
        {
            if (flightId != null)
            {
                fsdl.RemoveFlightScheduleByFlightId(flightId);
            }
        }

        //Method to REMOVE an schedule of flight by flightScheduleId
        public void RemoveFlightScheduleByFlightScheduleId(string flightScheduleId)
        {
            if (flightScheduleId != null)
            {
                fsdl.RemoveFlightScheduleByFlightScheduleId(flightScheduleId);
            }
        }

        public bool CheckFlightId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
 