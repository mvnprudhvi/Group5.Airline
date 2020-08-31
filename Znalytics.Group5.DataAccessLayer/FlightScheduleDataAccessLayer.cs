//'...........KEERTHANA...........

//Impoting Statements
using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;
using Znalytics.Group5.Airline.FlightModule.Entities;
using Znalytics.Group5.Airline.FlightModule.DataAccessLayer;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;
using Newtonsoft.Json;
using System.IO;

/// <summary>
/// represents dataAccessLayer of Flight
/// </summary>
namespace Znalytics.Group5.Airline.FlightScheduleModule.DataAccessLayer
{
    /// <summary>
    /// Represents the class for Flight Schedule
    /// </summary>
    public class FlightScheduleDataAccessLayer : IFlightScheduleDataAccessLayer
    {
        //Created a list for flight Schedule
        public static List<FlightSchedule> _scheduleList
        {
            set
            {
                _scheduleList = value;
            }
            get
            {
                return _scheduleList;
            }
        }


        //Static Constructor
        static FlightScheduleDataAccessLayer()
        {
            _scheduleList = new List<FlightSchedule>()
            {
                //Sample information
                new FlightSchedule() { flightId = "FID1011", FlightScheduleId = "FSID01", Source = "HYDERABAD", Destination = "MUMBAI"},
                new FlightSchedule() { flightId = "FID1022", FlightScheduleId = "FSID02", Source = "MUMBAI", Destination = "CHENNAI"},
                new FlightSchedule() { flightId = "FID1033", FlightScheduleId = "FSID03", Source = "BANGALORE", Destination = "DELHI"},
                new FlightSchedule() { flightId = "FID1044", FlightScheduleId = "FSID04", Source = "HYDERABAD", Destination = "DELHI"},
                new FlightSchedule() { flightId = "FID1022", FlightScheduleId = "SFSID02", Source = "HYDERABAD", Destination = "BANGALORE" }
            };
        }

        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        public void SaveIntoFile()
        {

            string str = JsonConvert.SerializeObject(_scheduleList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\FlightSchedule.txt");
            streamWriter.Write(str);
            streamWriter.Close();
        }

        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public List<FlightSchedule> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\FlightSchedule.txt");
            string str1 = streamReader.ReadToEnd();
            List<FlightSchedule> flightSchedule = JsonConvert.DeserializeObject<List<FlightSchedule>>(str1);
            return flightSchedule;

        }
        /// <summary>
        /// Method to ADD Schedules to the list
        /// </summary>
        /// <param name="schedule"></param>
        public void AddSchedule(FlightSchedule schedule)
        {
            //Condition to check whether the flightId exists or not
            if (!_scheduleList.Exists(temp => temp.flightId == schedule.flightId))
            {
                _scheduleList.Add(schedule);
                SaveIntoFile();

            }
            else
            {
                throw new Exception("flight Id doesnot exist");
            }
        }

        /// <summary>
        ///  // Method to GET the added Schedules
        /// </summary>
        /// <returns></returns>
        public List<FlightSchedule> GetSchedule()
        {
            return _scheduleList;
            
        }

        /// <summary>
        /// Method to GET the added schedule Details
        /// </summary>
        /// <param name="flightScheduleID">Represents AddressId</param>
        /// <returns></returns>
        public FlightSchedule GetScheduleByFlightScheduleId(string flightScheduleId)
        {
            //Condition to check whether the flightScheduleId exists or not
            if (_scheduleList.Exists(temp => temp.flightScheduleId == flightScheduleId))
            {

                return _scheduleList.Find(temp => temp.flightScheduleId == flightScheduleId);
            }
            else
            {
                throw new FlightException("flightSchedule id doesn't exist");
            }

        }



        ///Method to REMOVE an flightSchedule of the flight by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId">Represents flightScheduleId</param>
        /// </summary>
        public void RemoveFlightScheduleByFlightScheduleId(string flightScheduleId)
        {
            //Condition to check whether the AddressId exists or not
            if (_scheduleList.Exists(temp => temp.flightScheduleId == flightScheduleId))
            {
                //It removes all the condition matching elements
                _scheduleList.RemoveAll(temp => temp.flightScheduleId == flightScheduleId);

                SaveIntoFile();
            }
            else
            {
                throw new FlightException("FlightSchedule id doesn't exist");
            }

        }


        ///Method to REMOVE an flightSchedule of the flight by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId">Represents flightScheduleId</param>
        /// </summary>
        public void RemoveFlightScheduleByFlightId(string flightId)
        {
            //Condition to check whether the AddressId exists or not
            if (_scheduleList.Exists(temp => temp.FlightId == flightId))
            {
                //It removes all the condition matching elements
                _scheduleList.RemoveAll(temp => temp.FlightId == flightId);

                SaveIntoFile();
            }
            else
            {
                throw new FlightException("FlightSchedule id doesn't exist");
            }

        }





        /// <summary>
        /// //Method to GET Source by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetSourceByFlightScheduleId(string flightScheduleId)
        {

            return _scheduleList.FindAll(temp => temp.FlightScheduleId == flightScheduleId);

        }

        /// <summary>
        /// //Method to GET Destination by flightScheduleId
        /// </summary>
        /// <param name="flightScheduleId"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetDestinationByFlightScheduleId(string flightScheduleId)
        {

            return _scheduleList.FindAll(temp => temp.FlightScheduleId == flightScheduleId);

        }




        /// <summary>
        /// //Method to GET schedules  by Source
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleBySource(string source)
        {

            return _scheduleList.FindAll(temp => temp.Source == source);

        }

        /// <summary>
        /// Method to GET schedules  by Destination
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        public List<FlightSchedule> GetScheduleByDestination(string destination)
        {

            return _scheduleList.FindAll(temp => temp.Destination == destination);

        }



        /// <summary>
        /// //Method to UPDATE source of Flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateSource(FlightSchedule schedule)
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.Source = schedule.Source;


            }
            else
            {

                throw new FlightException("FlightScheduleId doesn't exist");
            }
        }




        /// <summary>
        /// Method to UPDATE Destinantion of Flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateDestination(FlightSchedule schedule)
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.Destination = schedule.Destination;


            }
            else
            {

                throw new FlightException("FlightScheduleId doesn't exist");
            }
        }

        /// <summary>
        /// method to UPDATE DepartureTiming of flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateDepartureTiming(FlightSchedule schedule)// update Destination of flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.DepartureTiming = schedule.DepartureTiming;


            }

        }

        /// <summary>
        /// /method to UPDATE ArrivalTiming of flight
        /// </summary>
        /// <param name="schedule"></param>
        public void UpdateArrivalTiming(FlightSchedule schedule)// update Destination of flight
        {
            FlightSchedule fs = _scheduleList.Find(temp => temp.FlightScheduleId == schedule.FlightScheduleId);
            if (fs != null)
            {
                fs.ArrivalTiming = schedule.ArrivalTiming;


            }
        }


        public static bool CheckFlightScheduleId(string id)
        {
            bool result = _scheduleList.Exists(temp => temp.FlightScheduleId == id);
            return result;
        }
    }
}











