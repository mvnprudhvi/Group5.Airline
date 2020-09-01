//using System;
/*using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
namespace Znalytics.Group5.Airline.DataAccessLayer
{
   
      public interface IFlightDataAccessLayer
    {
        //method to add flight Details to the list
        void AddFlight(Flight flight);

        //Method to GET the added details
        List<Flight> GetFlights();

        void UpdateFlightByFlightId(Flight flight);

        //method to update flight by flightName
        void UpdateFlightByFlightName(Flight flight);

        //method  to remove flight by flightname
        void RemoveFlightByFlightId(string flightId);

        //method to remove flight by flightName
        void RemoveFlightByFlighthName(string flightName);

        //method to get flight by flightId
        Flight GetFlightByFlightId(string flightId);


    }
}


