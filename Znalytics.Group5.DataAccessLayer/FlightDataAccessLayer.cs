using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;


namespace Znalytics.Group5.DataAccessLayer
{
   public class FlightDataAccessLayer : IFlightDataAccessLayer
    {
        //create list
        private static List<Flight> flights;

        //constructor
        static FlightDataAccessLayer()
        {
            flights = new List<Flight>()
            {
                new Flight() {flightNumber = 1011 , flightName = "AIRINDIA" , flightCapacity = 250 , LuggageWeightage =20 },
                new Flight() {flightNumber = 1022 , flightName = "INDIGO" , flightCapacity = 225 , LuggageWeightage =15 },
                new Flight() {flightNumber = 1033 , flightName = "GOAIR" , flightCapacity = 250 , LuggageWeightage =20 },
                new Flight() {flightNumber = 1011 , flightName = "JETBLUE" , flightCapacity = 100 , LuggageWeightage =15 },

            };
        }
        public void AddFlights(Flight flight)
        {
            flights.Add(flight);
        }

       public void UpdateFlightNameByFlightId(Flight flight)
        {
            flights.Update(flight);
        }
    }
}












































































































