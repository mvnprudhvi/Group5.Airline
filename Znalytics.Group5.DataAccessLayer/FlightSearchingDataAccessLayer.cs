
// created by Reshma
/*using System.Collections.Generic;


using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

namespace Znalytics.Group5.Airline.FlightSearchingDataAcessLayer
{
    /// <summary>
    /// This Class Represents DataAcessLayer Of FlightSearching
    /// </summary>
    public class FlightSearchingDataAccessLayer : IFlightSearchingDataAccessLayer
    {
        //private fields
        private static List<Flight> _flight;

        //constructor
        static FlightSearchingDataAccessLayer()
        {
            _flight = new List<Flight>();



        } //Add
        public void AddFlightSearching(Flight flightId)
        {
            _flight.Add(flightId);
        }


        //Get all details of flight
        public List<Flight> GetFlightSearching()
        {
            return _flight;
        }

        /*//Update
        public void UpdateFlightSearching(Flight flightId)
        {
            //Get matching flightnames based on flightname
            Flight fs = _flight.Find(temp => temp.FlightId == fs.flightId);
            if (fs != null)
            {
                fs.flightId= Flight.flightId;
            }
        }*/


        public List<Flight> Flight(string flightName)
        {
            List<Flight> samp = FlightDataAccessLayer._flightList;
            List<Flight> res = samp.FindAll(temp => temp.FlightName == flightName);
            return res;
        }
        public List<Flight> GetFlightsByFlightId(string flightId)
        {
            List<Flight> samp = FlightDataAccessLayer._flightList;
            List<Flight> res = samp.FindAll(temp => temp.FlightId == flightId);
            return res;
        }


        public List<FlightSchedule> GetScheduleBySource(string source)
        {
            List<FlightSchedule> samp = FlightDataAccessLayer._scheduleList;
            List<FlightSchedule> res = samp.FindAll(temp => temp.Source == source);
            return res;
        }
        public List<FlightSchedule> GetScheduleByDestination(string destination)
        {
            FlightScheduleDataAccessLayer sample = new FlightScheduleDataAccessLayer();
            
            return sample.GetFlightsByDestination(destination);
        }


}*/



  








           
  

