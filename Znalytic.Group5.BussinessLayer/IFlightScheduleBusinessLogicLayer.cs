////........KEERTHANA....
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;



namespace Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer
{

    /// <summary>
    /// Represents an interface of FlightScheduleBusinessLogicLayer
    /// </summary>
     interface IFlightScheduleBusinessLogicLayer
    {

        /// <summary>
        //Method to add flightSchedule details to the list
        /// </summary>
        /// <param name="fs"></param>
        void AddSchedule(FlightSchedule fs);

        /// <summary>
         /// Method to get  added schedule details to the list
         /// </summary>
         /// <returns></returns>
        List<FlightSchedule> GetSchedule();

        


        //Method to get the flightsSchedule by Destination
        List<FlightSchedule> GetScheduleByDestination(string destination);

    }
}