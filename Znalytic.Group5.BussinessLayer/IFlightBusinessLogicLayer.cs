﻿using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;

namespace Znalytic.Group5.Airline.FlightModule.BussinessLogicLayer
{
    public interface IFlightBusinessLogicLayer
    {
        void AddFlight(Flight flight);
        void UpdateFlightNameByFlightId(Flight flight);

        void RemovetFlightByFlightId(string flightId);
        List<Flight> GetFlights();

        Flight GetFlightByFlightId(string flightId);
    }
}

