namespace Znalytics.Group5.Airline.FlightSearchingDataAcessLayer
{
    public interface IFlightSearchingDataAccessLayer
    {
        void AddFlightSearching(FlightSearching FlightID);

        void UpdateFlightSearching(FlightSearching FlightID);


        List<Flight> FlightSearching(string FlightName);
        List<FlightSchedule> FlightSearching(string Source);
        List<FlightSchedule> FlightSearching(string Destination);
    }
}