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



        /// <summary>
        /// Method to ADD flight details to the list
        /// </summary>
        /// <param name="flight">Represents flight object</param>
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

        /// <summary>
        /// Method to GET the added details
        /// </summary>
        /// <returns>It returns the list of flights</returns>
        public List<Flight> GetFlights()
        {
            return fdal.GetFlights();
        }


        /// <summary>
        /// Method to GET flightDetails by flightId
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method to GET flight details by WareHouseId
        /// </summary>
        /// <param name="flightId">Reprents flight id</param>
        /// <returns></returns>

        //Method to REMOVE flight  by flightId
        public void RemovetFlightByFlightId(string flightId)
        {
            try
            {
                //flight Id should not be null
                if (flightId != null)
                {
                    fdal.RemoveFlightByFlightId(flightId);
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
                    fdal.RemoveFlightByFlighthName(flightName);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }
        }

        /// <summary>
        /// Method to UPDATE flight by flightName
        /// </summary>
        /// <param name="flight"></param>
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

        /// <summary>
        /// Method to update flight by flightId
        /// </summary>
        /// <param name="flight"></param>
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

        /// <summary>
        /// Method to check whether flightId exists or not
        /// </summary>
        /// <param name="id">Represents flight id</param>
        /// <returns></returns>
        public bool CheckFlightId(string id)
        {
            return FlightDataAccessLayer.CheckFlightId(id);
        }



    }
}
