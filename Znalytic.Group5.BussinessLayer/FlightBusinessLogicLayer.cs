//Importing Statements
using System.Collections.Generic;
using System.Runtime.Serialization;
using  Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.Entities;

//Created a namespace for BusinessLayer of flight module
namespace Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer
{ 

    /// <summary>
    /// Represents BusinessLogic class of flight and Implementing an interface
    /// </summary>

   public class FlightBusinessLogicLayer : IFlightBusinessLogicLayer
   {
    
         FlightDataAccessLayer fdal;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public FlightBusinessLogicLayer()
        {
       //Creating object for DataAcessLayer and storing  in reference variable
        fdal = new FlightDataAccessLayer();
        }

        

        //Method to ADD FlightDetails to the list
        public void AddFlight(Flight flight)
        {

            try
            {
                //flight Id should not be null 
                if (flight.FlightId != null)
                {

                    fdal.AddFlight(flight);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        // Method to GET the added details
        public List<Flight> GetFlights()
        {
            return fdal.GetFlights();
        }

       
        //Method to GET flightDetails by flightId
        public Flight GetFlightByFlightId(string flightId)
        {
            try
            {
                //flight Id should not be null
                if (flightId != null)
                {
                    return fdal.GetFlightByFlightId(flightId);
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
                    fdal.RemovetFlightByFlightId(flightId);
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
                    fdal.RemoveFlightByFlightName(flightName);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        //Method to UPDATE flight by flightName
        public void UpdateFlightByFlightName(Flight flight)
        {

            try
            {
                //flight Id should not be null
                if (flight.FlightName != null)
                {
                    fdal.UpdateFlightByFlightName(flight);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        //Method to UPDATE flight by flightId
        public void UpdateFlightByFlightId(Flight flight)// update flightid
        {

            try
            //flight Id should not be null
            {
                if (flight.FlightId != null)
                {
                    fdal.UpdateFlightByFlightId(flight);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

      
    }
}
