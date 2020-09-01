// created by Reshma

using System;
namespace Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer
{
    public interface IFlightSearchingbusinessLogicLayer
    {
        void Add(FlightName FlightName);
        List<FlightSearching> GetFlightSearchings();
        List<Flight> GetFlightsByFlightName(string FlightName);
        List<Flight> GetFlightsByFlightId(string FlightId);
        
         List<FlightSchedule> GetFlightSchedulesBySource(string Source);
        List<FlightSchedule> GetFlightSchedulesByDestination(string Destination);



    }
}
