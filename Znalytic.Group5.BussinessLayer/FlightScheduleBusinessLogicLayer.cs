//........KEERTHANA....
using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.BussinessLogicLayer;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
namespace Znalytic.Group5.Airline.FlightScheduleModule.BussinessLogicLayer
{
    public class FlightScheduleBusinessLogicLayer : IFlightScheduleBusinessLogicLayer
    {


        FlightScheduleDataAccessLayer _fdal;

        public FlightScheduleBusinessLogicLayer()
        {
            _fdal = new FlightScheduleDataAccessLayer();
        }

       /// <summary>
       /// validating Source
       /// </summary>
       /// <param name="flightSchedule"></param>
        public void AddSchedule(FlightSchedule flightSchedule)
        {
            if(flightSchedule.Source != null )
            {
                _fdal.AddSchedule(flightSchedule);
            }
            else
            {
                Console.WriteLine("Source can't be Null");
            }
        }

        /// <summary>
        /// methods for validating FlightId
        /// </summary>
        /// <param name="fd"></param>
        public void AddflightId(FlightSchedule fs)
        {
            if (fs.flightId < 10)
            {
                _fDal.AddflightId(fs.flightId);
            }
            else
            {
                Console.WriteLine("flightId can't be Null");
            }
        }
        //GetAll Flights
        public List<FlightSchedule> GetFlightSchedule
        {
            get
            {
                return _fDal.GetFlightSchedule();
            }
        }

        public void UpdateExistingFlightSchedule(FlightSchedule fs)
        {
           
        }
    }
}





