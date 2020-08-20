using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.DataAccessLayer;
using Znalytic.Group5.Airline.Entities;

namespace Znalytic.Group5.Airline.BussinessLogicLayer
{
    public class FlightDetailBusinessLogic
    {
        FlightDetailsDataAccessLogic _flightsDataAccessLogic;

        public FlightDetailBusinessLogic()
        {
            _flightsDataAccessLogic = new FlightDetailsDataAccessLogic();
        }

        //Add
        public void Add(FlightDetail flight)
        {
            if (flight.flightName != null)
            {
                _flightsDataAccessLogic.Add(flight);
            }
            else
            {
                throw new Exception("Flight Name should not be null");
            }
        }
        //GetAll Flights
        public List<FlightDetail> GetEmployees()
        {
            return _flightsDataAccessLogic.GetFlightDetails();
        }
        public void UpdateFlightDetails(FlightDetail flight)
        {
            if (flight.flightName != null)
            {
                _flightsDataAccessLogic.UpdateEmployee(flight);
            }
        }
    }
}