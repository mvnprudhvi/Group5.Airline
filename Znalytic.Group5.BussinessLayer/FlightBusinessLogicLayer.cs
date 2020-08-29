//Importing Statements
using System.Collections.Generic;
using  Znalytics.Group5.Airline.Flight.DataAccessLayer;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytic.Group5.Airline.FlightModule.BussinessLogicLayer;

//Created a namespace for BusinessLayer of flight module
namespace Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents BusinessLogic class of flight and Implementing an interface
    /// </summary>

    public class FlightBusinessLogicLayer : IFlightBusinessLogicLayer
    {


        /// <summary>
        /// Default Constructor
        /// </summary>
        public FlightBusinessLogicLayer()
        {

            // fdal = new FlightDataAccessLayer();
        }

        //Method to ADD FlightDetails to the list
        public void AddFlight(Flight flight)
        {

            try
            {
                //WareHouse Id should not be null 
                if (flight.flightId != null)
                {

                    FlightDataAccessLayer.AddFlight(flight);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        // Method to GET the added details
        public List<Flight> Getflights()
        {
            return FlightDataAccessLayer.Getflights();
        }

        //Method to GET flightDetails by flightId
        public Flight GetFlightByFlightId(string flightId)
        {
            try
            {
                //flight Id should not be null
                if (flightId != null)
                {
                    return FlightDataAccessLayer.GetFlightByFlightId(flightId);
                }
                else
                {
                    return null;
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        //Method to REMOVE flight  by flightId
        public void RemovetFlightByFlightId(string flightId)
        {
            try
            {
                //flight Id should not be null
                if (flightId != null)
                {
                    FlightDataAccessLayer.RemovetFlightByFlightId(flightId);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        //Method to REMOVE fligt  by flightName
        public void RemoveFlightByFlightName(string flightName)
        {

            try
            {
                //flight Name should not be null
                if (flightName != null)
                {
                    FlightDataAccessLayer.RemoveFlightByFlightName(flightName);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        //Method to UPDATE flightName
        public void UpdateflightName(Flight flight)// update flight Name
        {

            try
            {
                //flight Id should not be null
                if (Flight.flightId != null)
                {
                    FlightDataAccessLayer.UpdateflightName(flight);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        //Method to UPDATE flightId
        public void UpdateflightId(Flight flight)// update flightid
        {

            try
            //WareHouse Id should not be null
            {
                if (Flight.flightId != null)
                {
                    FlightDataAccessLayer.UpdateflightId(flight);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }



    }
}