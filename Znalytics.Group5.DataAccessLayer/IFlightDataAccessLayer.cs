//using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public interface IFlightDataAccessLayer
    {
        void AddFlight(Flight flight);
        List<Flight> GetFlights();

        void UpdateFlights(Flight flight);
        void DeleteFlight(Flight flight);
        Flight GetFlightByFlightId(string flightId);


    }
}

