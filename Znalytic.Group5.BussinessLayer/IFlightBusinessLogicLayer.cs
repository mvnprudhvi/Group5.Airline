using Znalytics.Group5.Airline.FlightModule.Entities;

namespace Znalytic.Group5.Airline.FlightModule.BussinessLogicLayer
{
    public interface IFlightBusinessLogicLayer
    {
        void AddFlights(Flight flight);
        void UpdateFlightNameByFlightId(Flight flight);
        void AddFlight(Flight flight);
        List<Flight> Getflights();

        Flight GetflightByflightId(string flightId);
    }
}
