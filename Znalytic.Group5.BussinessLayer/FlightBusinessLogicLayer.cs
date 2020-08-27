using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytic.Group5.Airline.BussinessLogicLayer;
using Znalytics.Group5.Airline.DataAccessLayer;

namespace Znalytic.Group5.Airline.BusinessLayer
{
    public class FlightBusinessLogicLayer : IFlightBusinessLogicLayer
    {
        private FlightDataAccessLayer fdl;
      public FlightBusinessLogicLayer() 
        {
             fdl = new FlightDataAccessLayer();

        }
         //Add
         public void AddFlights(Flight flight)
         {
            if(flight.flightName != null)
            {
                fdl.AddFlights(flight);
            }
            else
            {
                throw new Exception("Flight Name can't be null");
            }
         }
        //GetAllFlightSchedule
        public List<Flight> Getflights()
        {
            return fdl.Getflights();
        }
        public Flight GetFlightByFlightId(int flightId)
        {
            if(flight.flightNumber != 0)
            {
                fdl.UpdateFlights(flight);
            }
            else
            {
                throw new Exception("FlightNumber can't be 0");
            }
        }

    }
}
