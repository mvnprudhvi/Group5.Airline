//........KEERTHANA....
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;
namespace Znalytic.Group5.Airline.BussinessLogicLayer
{
    public class FlightDetailBusinessLogic : IFlightDetailBusinessLogic
    {
        //List<string> Flight Details = new List<string>();
       
        FlightDetailsDataAccessLogic _fDal;

        public FlightDetailBusinessLogic()
        {
            _fDal = new FlightDetailsDataAccessLogic();
        }

        /// <summary>
        /// validating FlightName
        /// </summary>
        /// <param name="fd"></param>
        public void AddflightName(FlightDetail fd)
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
        public void AddflightId(FlightDetail fd)
        {
            if (fd.flightId < 10)
            {
                _fDal.AddflightId(fd.flightId);
            }
            else
            {
                Console.WriteLine("flightId can't be Null");
            }
        }
        //GetAll Flights
        public List<FlightDetail> GetFlightDetails
        {
            get
            {
                return _fDal.GetFlightDetails();
            }
        }

        public void UpdateExistingFlightDetails(FlightDetail fd)
        {
           
        }
    }
}





