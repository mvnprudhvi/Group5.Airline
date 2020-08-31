using System.Collections.Generic;


using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;

namespace Znalytics.Group5.Airline.FlightSearchingDataAcessLayer
{
    public class FlightSearchingDataAcessLayer
    {
        //private fields
        private static List<FlightSearchingDataAcessLayer> _FlightSearching;

        //constructor
        static FlightSearchingDataAcessLayer()
        {
            _FlightSearching = new List<FlightSearchingDataAcessLayer>();

         
            
            //Add
            public void Add(FlightSearching FlightSearching)
        {
            _FlightSearching.Add(FlightSearching);
        }

        //Get all details of flight
        public List<FlightSearching> GetFlightSearching()
        {
            return _FlightSearching;
        }

        //Update
        public void UpdateFlightSearching(FlightSearching FlightSearching)
        {
            //Get matching flightnames based on flightname
            _FlightSearching fs = _FlightSearching.Find(temp => temp.FlightID == fs.FlightID);
            if (fs != null)
            {
                fs.flightName = Flight.FlightName;
            }
        }
       

            public List<Flight> FlightSearching(string FlightName)
            {
                List<Flight> samp=FlightDataAccessLayer._flightList;
                List<Flight> res = samp.FindAll(temp => temp.FlightName == FlightName);
                return res;
            }



       
    }
}


  








           
  

