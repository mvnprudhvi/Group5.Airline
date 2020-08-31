//Importing Statements
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightBookingModule.Entities;

namespace Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer
{
     interface IFlightBusinessLogicLayer
    {
        //method to add flight details
        void AddFlight(Flight flight);

        /// <summary>
        /// Method to Get the list of flights
        /// </summary>
        /// <returns></returns>
        List<Flight> GetFlights();

        //method to remove flight by flightName
        void RemoveFlightByFlightName(string flightName);

        //Method to Remove flight by flightId
        void RemovetFlightByFlightId(string flightId);


        /// <summary>
        /// Method to GetFlightByFlightId
        /// </summary>
        /// <param name="flightId">Represents flightId</param>
        /// <returns></returns>
        Flight GetFlightByFlightId(string flightId);
    }
}