////........KEERTHANA....
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer;



namespace Znalytic.Group5.Airline.FlightScheduleModule.BusinessLogicLayer
{
    public interface IFlightScheduleBusinessLogicLayer
    {

        //Method to add flightSchedule to the list
       public void AddSchedule(FlightSchedule fs);

        // Method to display the added flightsSchedule
        List<FlightSchedule> GetSchedule();

        //Method to get flightsSchedule by flightScheduleId
        List<FlightSchedule> GetScheduleByFlightScheduleId(string flightScheduleId);

        //Method to get the flightsSchedule by WareHouseID
        List<FlightSchedule> GetScheduleByFlightId(string flightId);

    }
}