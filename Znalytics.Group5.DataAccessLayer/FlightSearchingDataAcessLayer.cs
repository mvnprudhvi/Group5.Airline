

using System.Collections.Generic;

using Znalytics.Group5.Flightsearching.Entities;

namespace Znalytics.Group5.Airline.FlightsearchingDataAccessLayer
{



    public class FlightsearchingDataAccessLogic
    {
        //private fields
        private static List<FlightsearchingDataAccessLogic> _Flightsearching;

        //constructor
        static FlightsearchingDataAccessLogic()
        {
            _Flightsearching = new List<FlightsearchingDataAccessLogic>()
            {
                new _Flightsearching(){ FlightID = 102, FlightName= "SpiceJet" },
                new _Flightsearching(){ FlightID= 103,FlightName= "AirAsia India" }
            };
        }

        //Add
        public void Add(Flightsearching Flightsearching)
        {
            _Flightsearching.Add(Flightsearching);
        }

        //Get all details of flight
        public List<Flightsearching> GetFlightsearching()
        {
            return _Flightsearching;
        }

        //Update
        public void UpdateFlightsearching(Flightsearching Flightsearching)
        {
            //Get matching flightnames based on flightname
            _Flightsearching fs = _Flightsearching.Find(temp => temp.FlightID == fs.FlightID);
            if (fs != null)
            {
                fs.flightName = Flight.FlightName;
            }
        }
    }
}

    //
   

  //  








            //Add
  // public class FlightSearchingDataAccessLayer
    {
        //create list
        List<FlightName> FlightName = new List<FlightName>();

        public void AddFlightName(FlightName FlightName )
        {

        }
    //}
//
