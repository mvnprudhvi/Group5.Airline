//Importing Statements
using Znalytics.Group5.Airline.FlightModule.Entities;

namespace Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer
{
     interface IFlightBusinessLogicLayer
    {
        //method to add flight details
        void AddFlight(Flight flight);

        //method to remove flight by flightName
        void RemoveFlightByFlightName(string flightName);

        //Method to Remove flight by flightId
        void RemovetFlightByFlightId(string flightId);
        
        //Method to get flight by flightId
        Flight GetFlightByFlightId(string flightId);
    }
}