using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytic.Group5.Airline.Entities;

namespace Znalytic.Group5.Airline.BussinessLogicLayer
{
    public class FlightDetailBusinessLogic
    {
        FlightDetailsDataAccessLogic _fDal;

        public FlightDetailBusinessLogic()
        {
            _fDal = new FlightDetailsDataAccessLogic();
        }

        //Add
        public void Add(FlightDetail flight)
        {
            if (flight.flightName != null)
            {
                _fDal.Add(flight);
            }
            else
            {
                throw new Exception("Flight Name should not be null");
            }
        }
        //GetAll Flights
        public List<FlightDetail> GetFlightDetails()
        {
            return _fDal.GetFlightDetails();
        }

        public void UpdateFlightDetails(FlightDetail flight)
        {
            if (flight.flightId != null)
            {
                _fDal.UpdateFlightDetails(flight);
            }
        }
    }
}