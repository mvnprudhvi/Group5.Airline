using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.FlightDetailModule.Entities;
/// <summary>
/// represents dataAccessLayer for Flight
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
   public class FlightDetailDataAccessLayer
    {

        //create list

        List<FlightDetailDataAccessLayer> listOfFlightDetail = new List<FlightDetailDataAccessLayer>();

        /// <summary>
        /// Adding new flight Details
        /// </summary>
        /// <param name="flight">Attribute to add new flight</param>
        public void AddToList(string flightName, String flightId)
        {
            listOfFlightDetail.Add(new FlightDetail{ flightName = "HYD", flightId = "123" });
           
        }
            
     /// <summary>
     /// Delete Method with 2 parameters
     /// </summary>
     /// <param name="flightId"></param>
     /// <param name="flightName"></param>
     public void DeleteFlightDetailByflightId(string flightId,string flightName)
        {
            listOfFlightDetail.RemoveAll(temp => temp.flightId == flightId && temp.flightName == flightName);
        }

        public void UpdateToList( string source, string destination)
        {
            listOfFlightDetail
        }
            
            
        
    }
}
