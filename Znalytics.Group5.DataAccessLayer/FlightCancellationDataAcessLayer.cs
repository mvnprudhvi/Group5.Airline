//created by Madhumitha
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

/// <summary>
/// represents dataAccessLayer of Flightcancellation
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public class FlightCancellationDataAccessLogic
    {

        // create list
        private static List<FlightCancellationDataAccessLogic> _flights = new List<FlightCancellationDataAccessLogic>();

        //Add
        public void AddFlightDetail(FlightCancellation flight)
        {
            _flights.Add(flight);
        }

        //Get all FlightDetails
        public List<FlightDetail> GetFlightDetails()
        {
            return _flights;
        }


        //Search.. details of flight using find()
        public void SearchFlightDetailsByName(string flightId, string flightName)
        {
            //Get matching flights based on flightId
            _flights.Contains()


        }

        //

        /// <summary>
        /// Delete Method with 2 parameters
        /// </summary>
        /// <param name="flightId"></param>
        /// <param name="flightName"></param>
        public void DeleteFlightDetailByflightId(string flightId, string flightName)
        {
            _flights.RemoveAll(temp => temp.flightId == flightId && temp.flightName == flightName);
        }

































/*using System.Collections.Generic;
using Znalytics.Group5.AirLine.CancellationModule.Entities;

namespace Znalytics.Group5.AirLine.CancellationDataAccessLayer
{
    public class FlightCancellationDataAccessLayer : CancellationDataAccessLayer
    {
        //create list
        List<FlightName> FlightName = new List<FlightName>();

        public void AddFlightName(FlightName FlightName)
        {
            ////flight generating new customer id

            //flight.Add(flight);

            //not done
        }
    }
}*/
