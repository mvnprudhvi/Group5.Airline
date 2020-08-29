
//using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.FlightModule.Entities;

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


        //static constructor
        static FlightDataAccessLayer()
        {
            _flightList = new List<Flight>()
            {
                new Flight() { FlightId = "FID1011", FlightName = "AIRINDIA", FlightTpe = "EconomySeats(or)BusinessSeats", LuggageWeightage ="30kgs",NoOfEconomySeats = 200 ,NoOfBusinessSeats = 20},
                new Flight() { FlightId = "FID1022", FlightName = "INDIGO", FlightTpe = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="25kgs", NoOfEconomySeats =150 , NoOfBusinessSeats = 10},
                new Flight() { FlightId = "FID1033", FlightName = "AIRGO", FlightTpe = "EconomySeats(or)BusinessSeats",LuggageWeightage ="30kgs" , NoOfEconomySeats = 220 , NoOfBusinessSeats = 25},
                new Flight() { FlightId = "FID1044", FlightName = "JETBLUE", FlightTpe = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="20kgs",NoOfEconomySeats = 200 ,NoOfBusinessSeats = 20}
            };

        }

        public string FlightId()
        {
            int flightId = _flightList.Max(temp =>temp.flightId);
            return flightId++;
        }

        //Method to ADD details to the list
        public void AddFlight(Flight flightDetails)
        {
            
                if (!_flightList.Exists(temp => temp.flightId == flightDetails.flightId))
                {
                    _flightList.Add(flightDetails);
                }
            
            else
            {
                throw new Exception("flight id already exists");
            }


        }

        // Method to GET the added details
        public List<Flight> Getflights()
        {
            return _flightList;
        }

        //Method to GET the Flight by flightId
        public Flight GetFlightByFlightId(string flightId)
        {
            Flight f = _flightList.Find(temp => temp.flightId == Flight.lightId);
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

        // Method to UPDATE the flight Name 
        public void UpdateFlightName(Flight flightId)
        {
            Flight f = _flightList.Find(temp => temp.FlightId == flightId);
            if (f != null)
            {
                f.FlightName = Flight.flightName;


            }

        }

        // Method to UPDATE the flight id
        public void UpdateFlightId(Flight flight)
        {
            Flight f = _flightList.Find(temp => temp.flightId == flight.flightId);
            if (f != null)
            {
                f.FlightId = flight.FlightId;
            }
        }

       
    }
}