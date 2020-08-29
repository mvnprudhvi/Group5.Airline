//........KEERTHANA......

//using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;

//Created a namespace for DataAccess Layer of flight Module
namespace Znalytics.Group5.Airline.FlightModule.DataAccessLayer
{
    /// <summary>
    /// Represents the class for flight Data
    /// </summary>
    public class FlightDataAccessLayer : IFlightDataAccessLayer
    {
        //create a list of Flight
        private static List<Flight> _flightList
        {
            set;
            get;
        }
        public string FlightName { get; private set; }


        //static constructor
        static FlightDataAccessLayer()
        {
            _flightList = new List<Flight>()
            {
                new Flight() { FlightId = "FID1011", FlightName = "AIRINDIA", FlightType = "EconomySeats(or)BusinessSeats", LuggageWeightage ="30kgs",NoOfEconomySeats = "200" ,NoOfBusinessSeats = "20"},
                new Flight() { FlightId = "FID1022", FlightName = "INDIGO", FlightType = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="25kgs", NoOfEconomySeats ="210" , NoOfBusinessSeats = "10"},
                new Flight() { FlightId = "FID1033", FlightName = "AIRGO", FlightType = "EconomySeats(or)BusinessSeats",LuggageWeightage ="30kgs" , NoOfEconomySeats = "150" , NoOfBusinessSeats = "25"},
                new Flight() { FlightId = "FID1044", FlightName = "JETBLUE", FlightType = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="20kgs",NoOfEconomySeats = "180" ,NoOfBusinessSeats = "20"}
            };

        }

        public string FlightId()
        {
            int flightId = _flightList.Max(temp => temp.FlightId);
            return FlightId++;
        }

        //Method to ADD details to the list
        public void AddFlight(Flight flight)
        {
            
                if (!_flightList.Exists(temp => temp.FlightId == flight.FlightId))
                {
                    _flightList.Add(flight);
                }
            
            else
            {
                throw new FlightException("flight id already exists");
            }


        }

        // Method to GET the added details
        public List<Flight> GetFlights()
        {
            return GetFlights();
        }

        //Method to GET the Flight by flightId
        public Flight GetFlightByFlightId(string flightId)
        {
            Flight f = _flightList.Find(temp => temp.FlightId == Flight.flightId);
            return f;
        }

        //Method to REMOVE Flight by FlightId
        public void RemovetFlightByFlightId(string flightId)
        {
            _flightList.RemoveAll(temp => temp.FlightId == Flight.flightId);

        }

        //Method to REMOVE Flight by flight Name
        public void RemoveFlightByFlightName(string flightName)
        {
            _flightList.RemoveAll(temp => temp.FlightName == Flight.flightName);
        }

        // Method to UPDATE the flight  By flightName
        public void UpdateFlightByFlightName(Flight flight)
        {
            Flight f = _flightList.Find(temp => temp.FlightName == flight.FlightName);
            if (f != null)
            {
                f.FlightName = Flight.flightName;


            }

        }

        // Method to UPDATE the flight id
        public void UpdateFlightByFlightId(Flight flight)
        {
            Flight f = _flightList.Find(temp => temp.FlightId == flight.FlightId);
            if (f != null)
            {
                f.FlightId = flight.FlightId;
            }
        }

       
    }
}