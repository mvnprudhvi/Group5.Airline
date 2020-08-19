using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.FlightsModule.Entities;
/// <summary>
/// represents dataAccessLayer for Flight
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
   public class FlightDetailDataAccessLayer
    {
        //create list

        private List<FlightDetail> _dataBase;

        public FlightDetailDataAccessLayer()
        {
            _dataBase = new List<FlightDetail>();
        }

        /// <summary>
        /// Adding new flight Details
        /// </summary>
        /// <param name="flight">Attribute to add new flight</param>
        public void AddFlight(FlightDetail flight)
        {
            _dataBase.Add(flight);
        }
            
             
            
            
        
    }
}
