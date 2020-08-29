////........KEERTHANA....
using System;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer;

namespace Znalytic.Group5.Airline.FlightScheduleModule.BussinessLogicLayer
{
    public interface IFlightScheduleBusinessLogicLayer
    {

        //Method to add flightSchedule to the list
       public void AddSchedule(FlightSchedule b);

        // Method to display the added flightsSchedule
        List<FlightSchedule> GetSchedule();

        //Method to get flightsSchedule by flightScheduleId
        List<FlightSchedule> GetScheduleByFlightScheduleId(string flightScheduleId);

        //Method to get the flightsSchedule by WareHouseID
        List<FlightSchedule> GetScheduleByFlightId(string flightId);

    }
}