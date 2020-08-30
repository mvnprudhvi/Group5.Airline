//........KEERTHANA......

//using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using Newtonsoft.Json;
using System.IO;
using System;

//Created a namespace for DataAccess Layer of flight Module
namespace Znalytics.Group5.Airline.FlightModule.DataAccessLayer
{
    /// <summary>
    /// Represents the class for flight Data and is static
    /// </summary>
    public class FlightDataAccessLayer : IFlightDataAccessLayer
    {
        //create a list of Flight
        private static List<Flight> _flightList
        {
            set;
            get;
        }
        


        //static constructor
        static FlightDataAccessLayer()
        {
            _flightList = new List<Flight>()
            {
                //mock data
                new Flight() { FlightId = "FID1011", FlightName = "AIRINDIA", FlightType = "EconomySeats(or)BusinessSeats", LuggageWeightage ="30kgs",NoOfEconomySeats = "200" ,NoOfBusinessSeats = "20"},
                new Flight() { FlightId = "FID1022", FlightName = "INDIGO", FlightType = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="25kgs", NoOfEconomySeats ="210" , NoOfBusinessSeats = "10"},
                new Flight() { FlightId = "FID1033", FlightName = "AIRGO", FlightType = "EconomySeats(or)BusinessSeats",LuggageWeightage ="30kgs" , NoOfEconomySeats = "150" , NoOfBusinessSeats = "25"},
                new Flight() { FlightId = "FID1044", FlightName = "JETBLUE", FlightType = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="20kgs",NoOfEconomySeats = "180" ,NoOfBusinessSeats = "20"}
            };
            

        }

        /* public string FlightId()
         {
             int flightId =System.Convert.ToInt32( _flightList.Max(temp => temp.FlightId));
             return flightId++;
         }*/

        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        public void SaveIntoFile()
        {

            string s = JsonConvert.SerializeObject(_flightList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\DesktopJson.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public List<Flight> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\DesktopJson.txt");
            string s1 = streamReader.ReadToEnd();
            List<Flight> flight = JsonConvert.DeserializeObject<List<Flight>>(s1);
            return flight;

        }


        /// <summary>
        /// Method to ADD details to the list
        /// </summary>
        /// <param name="flight"></param>
        public void AddFlight(Flight flight)
        {
            
                if (!_flightList.Exists(temp => temp.FlightId == flight.FlightId))
                {
                    _flightList.Add(flight);
                     SaveIntoFile();
                }
            
            else
            {
                throw new FlightException("flight id already exists");
            }


        }

        /// <summary>
        /// Method to GET the added details
        /// </summary>
        /// <returns></returns>
        public List<Flight> GetFlights()
        {
            return GetFlights();
            GetFiledata();

        }

        /// <summary>
        /// Method to GET the Flight by flightId
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        public Flight GetFlightByFlightId(string flightId)
        {
            Flight f = _flightList.Find(temp => temp.FlightId == Flight.flightId);
            return f;
        }

        

        /// <summary>
        /// Method to REMOVE Flight by FlightId
        /// </summary>
        /// <param name="flightId"></param>
        public void RemovetFlightByFlightId(string flightId)
        {
            _flightList.RemoveAll(temp => temp.FlightId == Flight.flightId);
            SaveIntoFile();
        }

        /// <summary>
        /// Method to REMOVE Flight by flight Name
        /// </summary>
        /// <param name="flightName"></param>
        public void RemoveFlightByFlightName(string flightName)
        {
            _flightList.RemoveAll(temp => temp.FlightName == Flight.flightName);
            SaveIntoFile();
        }

        /// <summary>
        /// Method to UPDATE the flight  By flightName
        /// </summary>
        /// <param name="flight"></param>
        public void UpdateFlightByFlightName(Flight flight)
        {
            Flight f = _flightList.Find(temp => temp.FlightName == flight.FlightName);
            if (f != null)
            {
                f.FlightName = Flight.flightName;
                SaveIntoFile();

            }
            else
            {
                throw new FlightException("flightName doesn't exist");
            }

        }

        /// <summary>
        ///  Method to UPDATE the flight by flight id
        /// </summary>
        /// <param name="flight"></param>
        public void UpdateFlightByFlightId(Flight flight)
        {
            Flight f = _flightList.Find(temp => temp.FlightId == flight.FlightId);
            if (f != null)
            {
                f.FlightId = flight.FlightId;
                SaveIntoFile();
            }
            else
            {
                throw new FlightException("flightid doesn't exist");
            }
        }

       


    }
}