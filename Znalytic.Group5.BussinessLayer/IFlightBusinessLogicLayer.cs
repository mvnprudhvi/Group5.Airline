using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;

namespace Znalytic.Group5.Airline.BussinessLogicLayer
{
   public interface IFlightBusinessLogicLayer
    {
        void AddFlights(Flight flight);
        void UpdateFlights(Flights flight);
    }
}
