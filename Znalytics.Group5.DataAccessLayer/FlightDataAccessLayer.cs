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
using System.Runtime.Remoting.Messaging;

//Created a namespace for DataAccess Layer of flight Module
namespace Znalytics.Group5.Airline.FlightModule.DataAccessLayer
{
    /// <summary>
    /// Represents the class for flight Data and is static
    /// </summary>
    public class FlightDataAccessLayer : IFlightDataAccessLayer
    {
        //create a list of Flight
        public static List<Flight> _flightList
        {
            set 
            {
                _flightList = value;
            }
            get
            {
                return _flightList;
            }
        }
        


        //static constructor
        static FlightDataAccessLayer()
        {
            _flightList = new List<Flight>()
            {
                //mock data
                new Flight() { FlightId = "1011", FlightName = "AIRINDIA", FlightType = "EconomySeats(or)BusinessSeats", LuggageWeightage ="30kgs",NoOfEconomySeats = "200" ,NoOfBusinessSeats = "20"},
                new Flight() { FlightId = "1022", FlightName = "INDIGO", FlightType = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="25kgs", NoOfEconomySeats ="210" , NoOfBusinessSeats = "10"},
                new Flight() { FlightId = "1033", FlightName = "AIRGO", FlightType = "EconomySeats(or)BusinessSeats",LuggageWeightage ="30kgs" , NoOfEconomySeats = "150" , NoOfBusinessSeats = "25"},
                new Flight() { FlightId = "1044", FlightName = "JETBLUE", FlightType = "EconomySeats(or)BusinessSeats" ,LuggageWeightage ="20kgs",NoOfEconomySeats = "180" ,NoOfBusinessSeats = "20"}
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
        private static void SaveIntoFile()
        {
            
            //Serialize object is stored in a reference variable of a string
            string s = JsonConvert.SerializeObject(_flightList);

            //Strean Writer writes data into file.
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\Flight.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }

        /// <summary>
        /// reading the data from Json file and return the data in the file in List format
        /// </summary>
        /// <returns>Returns List of flightdetails  avaliable int Flight.Txt</returns>
        public List<Flight> GetFiledata()
        {
            //Stream Reader reads the data from the given file
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\Flight.txt");
            string str = streamReader.ReadToEnd();

            //Deserialization converts Json data/string to Object
            List<Flight> flight = JsonConvert.DeserializeObject<List<Flight>>(str);
            return flight;

        }

        /// <summary>
        ///  Method to GET the added details
        /// </summary>
        /// <returns>It returns the list of flights</returns>
        public static List<Flight> GetFlight() => _flightList;//Used Linq

        /// <summary>
        /// Method to ADD Flightdetails to the list
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
        
       /* public void AddFlight(Flight flight)
        {
        if (_flightList.Count == 0)
            {
                flight.FlightId = 1;
            }
            else
            {
                flight.FlightId = _flightList.Max(temp => temp.FlightId) + 1;

                //Add flight object to the collection
                _flightList.Add(flight);
            }
        }
       /*/

        /// <summary>
        ///  Method to GET the added details
        /// </summary>
        /// <returns>It returns the list of flights</returns>
        public List<Flight> GetFlights()
        {
            return GetFlights();
           

        }


        /// <summary>
        /// Method to GET the FLIGHT by flightID
        /// </summary>
        /// <param name="flightD">Reprents flightid</param>
        /// <returns></returns>
        public Flight GetFlightByFlightId(string flightId)
        {
            {
                //Condition to check whether the flightScheduleId exists or not
                if (_flightList.Exists(temp => temp.FlightId == flightId))
                {

                    return _flightList.Find(temp => temp.FlightId == flightId);
                }
                else
                {
                    throw new FlightException("flightSchedule id doesn't exist");
                }
            }
        }




        /// <summary>
        /// Method to REMOVE Flight by FlightId
        /// </summary>
        /// <param name="flightId"></param>
        public  void RemoveFlightByFlighthId(string flightId)
        {
            //Condition to check whether the flightName exists or not
            if (_flightList.Exists(temp => temp.FlightId == flightId))
            {
                //It removes all the condition matching elements and is saved into the file
                _flightList.RemoveAll(temp => temp.FlightId == flightId);
                SaveIntoFile();
            }
            else
            {
                throw new FlightException("Flight doesn't exists by this name");
            }
        }

        /// <summary>
        /// Method to REMOVE Flight by flight Name
        /// </summary>
        /// <param name="flightName"></param>
        public  void RemoveFlightByFlighthName(string flightName)
        {
            //Condition to check whether the flightName exists or not
            if (_flightList.Exists(temp => temp.FlightName == flightName))
            {
                //It removes all the condition matching elements and is saved into the file
                _flightList.RemoveAll(temp => temp.FlightName == flightName);
                SaveIntoFile();
            }
            else
            {
                throw new FlightException("Flight doesn't exists by this name");
            }
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
                f.FlightName = flight.FlightName;
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
        public static bool CheckFlightId(string id)
        {
            bool result = _flightList.Exists(temp => temp.FlightId == id);
            return result;
        }



    }
}