//........KEERTHANA....
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
        // Method to GET the added  Schedules 
        public List<FlightSchedule> GetSchedule()
        {
            return fsdl.GetSchedule();
        }


        //Method to GET flight Schedule by flightScheduleId
        public List<FlightSchedule> GetScheduleByFlightScheduleId(string flightScheduleId)
        {
            return fsdl.GetScheduleByFlightScheduleId(flightScheduleId);
        }

        //Method to GET flightSchedule by scheduleId
        public List<FlightSchedule> GetScheduleByFlightId(string flightId)
        {
            return fsdl.GetScheduleByFlightId(flightId);
        }

       
        //Method to GET FlightSchedule by Source
        public List<FlightSchedule> GetScheduleBySource(string source)
        {
            return fsdl.GetScheduleBySource(source);
        }
        //Method to GET FlightSchedule by Destination
        public List<FlightSchedule> GetScheduleByDestination(string source)
        {
            return fsdl.GetScheduleByDestination(source);
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
        //Method to UPDATE DepartureTiming of flightSchedule
        public void UpdateDepartureTiming(FlightSchedule schedule)
        {

            if (schedule.FlightScheduleId != null)
            {
                fsdl.UpdateDepartureTiming(schedule);
            }
        }

        public void UpdateArrivalTiming(FlightSchedule schedule)
        {

            if (schedule.FlightScheduleId != null)
            {
                fsdl.UpdateArrivalTiming(schedule);
            }
        }
        //Method to REMOVE flight by flightId
        public void RemoveFlightByFlightId(string flightId)
        {
            if (flightId != null)
            {
                fsdl.RemoveFlightByFlightId(flightId);
            }
        }

        //Method to REMOVE an schedule of flight by flightScheduleId
        public void RemoveFlightByFlightScheduleId(string flightScheduleId)
        {
            if (flightScheduleId != null)
            {
                fsdl.RemoveFlightByFlightScheduleId(flightScheduleId);
            }
        }

    }
}