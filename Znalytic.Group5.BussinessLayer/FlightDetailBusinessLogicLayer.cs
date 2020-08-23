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

        //Add
        public void AddNewFlightDetails(FlightDetail fd)
        {
            _fDal.AddNewFlightDetails(fd);
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





