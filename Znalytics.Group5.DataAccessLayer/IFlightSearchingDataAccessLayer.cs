namespace Znalytics.Group5.Airline.FlightSearchingDataAcessLayer
{
    public interface IFlightSearchingDataAccessLayer
    {
        /// <summary>
        /// this method  add all the details of flightID
        /// </summary>
        /// <param name="FlightID"></param>
        void AddFlightSearching(FlightSearching FlightID);

        void UpdateFlightSearching(FlightSearching FlightID);


        List<Flight> FlightSearching(string FlightName);
        List<FlightSchedule> FlightSearching(string Source);
        List<FlightSchedule> FlightSearching(string Destination);
    }
}