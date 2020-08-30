
// created by 
using System.Collections.Generic;


using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

namespace Znalytics.Group5.Airline.FlightSearchingDataAcessLayer
{
    public class FlightSearchingDataAccessLayer : IFlightSearchingDataAccessLayer
    {
        //private fields
        private static List<FlightSearchingDataAccessLayer> _flightSearching;

        //constructor
        static FlightSearchingDataAccessLayer()
        {
            _flightSearching = new List<FlightSearching>();



            //Add
            public void AddFlightSearching(FlightSearching FlightID)
            {
                _flightSearching.Add(FlightID);
            }
        }
    }
            //Get all details of flight
            public List<FlightSearching> GetFlightSearching()
            {
                return _flightSearching;
            }

            //Update
            public void UpdateFlightSearching(FlightSearching FlightID)
            {
                //Get matching flightnames based on flightname
                _flightSearching fs = _flightSearching.Find(temp => temp.FlightID == fs.FlightID);
                if (fs != null)
                {
                    fs.flightID= Flight.FlightID;
                }
            }


           public  List<Flight> FlightSearching(string FlightName)
            {
                List<Flight> samp=FlightDataAccessLayer._flightList;
                List<Flight> res = samp.FindAll(temp => temp.FlightName == FlightName);
                return res;
            }
    public List<Flight> FlightSearching(string FlightId)
    {
        List<Flight> samp = FlightDataAccessLayer._flightList;
        List<Flight> res = samp.FindAll(temp => temp.FlightId == FlightId);
        return res;
    }


    public List<FlightSchedule> FlightSearching(string Source )
    {
        List<FlightSchedule> samp = FlightDataAccessLayer._scheduleList;
        List<FlightSchedule> res = samp.FindAll(temp => temp.Source == Source);
        return res;
    }
    public List<FlightSchedule> FlightSearching(string Destination)
    {
        List<FlightSchedule> samp = FlightDataAccessLayer._scheduleList;
        List<FlightSchedule> res = samp.FindAll(temp => temp.Destination== Destination);
        return res;
    }


}



  








           
  

