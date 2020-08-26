//........KEERTHANA....
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;
namespace Znalytic.Group5.Airline.BussinessLogicLayer
{
    public class FlightScheduleBusinessLogic : IFlightScheduleBusinessLogic
    {
        //List<string> Flight Details = new List<string>();

        FlightScheduleDataAccessLogic _fDal;

        public FlightScheduleBusinessLogic()
        {
            _fDal = new FlightScheduleDataAccessLogic();
        }

        /// <summary>
        /// validating FlightName
        /// </summary>
        /// <param name="fd"></param>
        public void AddflightName(FlightSchedule fs)
        {
            if(fd.flightName.Length < 15 )
            {
                _fDal.AddflightName(fd.flightName);
            }
            else
            {
                Console.WriteLine("flight name can't be Null");
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





