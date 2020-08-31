//........KEERTHANA....
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;
using Znalytics.Group5.Airline.Entities;
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
                else
                {
                    throw new Exception("flightScheduleId already exists");
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
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


        ///Method to GET flight Schedule by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        /// 
        public FlightSchedule GetScheduleByFlightScheduleId(string flightScheduleId)
        {
            try
            {
                //flight Id should not be null
                if (flightScheduleId != null)
                {
                    return fsdl.GetScheduleByFlightScheduleId(flightScheduleId);
                }
                else
                {
                    return null;
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        ///Method to GET flight Schedule by flightId
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        /// 
        public FlightSchedule GetScheduleByFlightId(string flightId)
        {
            try
            {
                //flight Id should not be null
                if (flightId != null)
                {
                    return fsdl.GetScheduleByFlightScheduleId(flightId);
                }
                else
                {
                    return null;
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        /// <summary>
        /// Method to GET FlightSchedule details by source
        /// </summary>
        /// <param name="locationsourceName">Represents source</param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleBySource(string source)
        {
            try
            {
                //Location Name should not be null
                if (source != null)
                {
                    //Calls the GetAddressByLocationName Method of WareHouseAddress Data Layer
                    return fsdl.GetScheduleBySource(source);
                }
                else
                {
                    return null;
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
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
        public bool CheckFlightScheduleId(string id)
        {
            return FlightScheduleDataAccessLayer.CheckFlightScheduleId(id);
        }

    }
}
 