using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;

namespace Znalytic.Group5.Airline.FlightModule.BussinessLogicLayer
{
    public interface IFlightBusinessLogicLayer
    {
        void AddFlight(Flight flight);
        void UpdateFlightNameByFlightId(Flight flight);
        
        List<Flight> GetFlights();

        Flight GetFlightByFlightId(string flightId);
    }
}
