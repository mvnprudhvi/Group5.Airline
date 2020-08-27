using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;


namespace Znalytics.Group5.DataAccessLayer
{
   public class FlightDataAccessLayer : IFlightDataAccessLayer
    {
        //create list
        List<Flight> flights = new List<Flight>();
        public void AddFlights(Flight flight)
        {
            flights.Add(flight);
        }

       public void UpdateFlights(Flight flight)
        {
            flights.Update(flight);
        }
    }
}
