/*
// created by Reshma
using System.Collections.Generic;


using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

namespace Znalytics.Group5.Airline.FlightSearchingDataAcessLayer
{
    /// <summary>
    /// This Class Represents DataAcessLayer Of FlightSearching
    /// </summary>
    public class FlightSearchingDataAccessLayer : IFlightSearchingDataAccessLayer
    {
        //private fields
        private static List<FlightSearching> _flightSearching;

        //constructor
        static FlightSearchingDataAccessLayer()
        {
            _flightSearching = new List<FlightSearching>();



        } //Add
            public  void AddFlightSearching(FlightSearching flightId)
            {
                _flightSearching.Add(flightId);
            }
        }
    }
            //Get all details of flight
            public List<FlightSearching> GetFlightSearching()
            {
                return _flightSearching;
            }

            //Update
            public void UpdateFlightSearching(FlightSearching flightId)
            {
                //Get matching flightnames based on flightname
                _flightSearching fs = _flightSearching.Find(temp => temp.FlightId == fs.flightId);
                if (fs != null)
                {
                    fs.flightId= Flight.flightId;
                }
            }


           public  List<Flight> FlightSearching(string flightName)
            {
                List<Flight> samp=FlightDataAccessLayer._flightList;
                List<Flight> res = samp.FindAll(temp => temp.FlightName == flightName);
                return res;
            }
    public List<Flight> GetFlightsByFlightId(string flightId)
    {
        List<Flight> samp = FlightDataAccessLayer._flightList;
        List<Flight> res = samp.FindAll(temp => temp.FlightId == flightId);
        return res;
    }


    public List<FlightSchedule> FlightSearching(string source )
    {
        List<FlightSchedule> samp = FlightDataAccessLayer._scheduleList;
        List<FlightSchedule> res = samp.FindAll(temp => temp.Source == source);
        return res;
    }
    public List<FlightSchedule> FlightSearching(string destination)
    {
        List<FlightSchedule> samp = FlightDataAccessLayer._scheduleList;
        List<FlightSchedule> res = samp.FindAll(temp => temp.Destination== destination);
        return res;
    }


}



  
*/







           
  

