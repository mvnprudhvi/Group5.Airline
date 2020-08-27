using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
namespace Znalytics.Group5.DataAccessLayer
{
    public interface IFlightDataAccessLayer
    {
        void AddFlights(Flight flight);
        void UpdateFlights(Flight flight);
    }
}
