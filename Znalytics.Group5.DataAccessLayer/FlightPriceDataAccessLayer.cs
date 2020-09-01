/*/// <summary>
/// Created By Dinesh
/// Module Name is FlightPrice
/// </summary>

//This Represents Importing Statements
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;
using Newtonsoft.Json;
using System.IO;

/// <summary>
/// Created a namespace for Data Access Layer of Airline Reservation System
/// </summary>
namespace Znalytics.Group5.Airline.DataAccessLayer
{
    /// <summary>
    /// This Class Represents Data Access Layer Of FlightPrice
    /// </summary>
    public class FlightPriceDataAccessLayer : IFlightPriceDataAccessLayer
    {
        //creating static list
        private static List<FlightPrice> _flightPrices;

        /// <summary>
        ///static constructor for  Data Access Layer
        ///Creating List to allocate the Memory only Once
        /// </summary>
        static FlightPriceDataAccessLayer()
        {
            //The Object of List class is stored in reference variable
            _flightPrices = new List<FlightPrice>();
        }

        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        private static void SaveIntoFile()
        {
            // Serialization converts an object into Json Format/ String
            //Serialize object is stored in a reference variable of a string
            string s = JsonConvert.SerializeObject(_flightPrices);

            //Strean Writer writes data into file.
            StreamWriter streamWriter = new StreamWriter(@"C:\FlightPricesList.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }

        /// <summary>
        /// reading the data from Json file and return the data in the file in List format
        /// <returns>Returns List of warehouses avaliable int FlightPricesList.Txt</returns>
        /// </summary>
        public static List<FlightPrice> GetFileData()
        {
            //Stream Reader reads the data from the given file
            StreamReader streamReader = new StreamReader(@"C:\FlightPricesList.txt");
            string s1 = streamReader.ReadToEnd();
            //Deserialization converts Json data/string to Object
            List<FlightPrice> fligthprice = JsonConvert.DeserializeObject<List<FlightPrice>>(s1);
            streamReader.Close();
            return fligthprice;
        }


        /// <summary>
        /// This Method Represents AddPrice to Add the FlightPrice Details into List
        /// </summary>
        /// <param name="price"></param>
        public void AddFlightPrice(FlightPrice price)
        {
            _flightPrices.Add(price);
            SaveIntoFile();
        }

        /// <summary>
        /// This Method Represents DeletePrice to Delete the FlightPrice Details into List
        /// </summary>
        /// <param name="price"></param>
        public void DeleteFlightPrice(FlightPrice price)
        {
            //Finding the ScheduleId Which Existing in List or not 
            FlightPrice dpri = _flightPrices.Find(temp => temp.FlightScheduleId == price.FlightScheduleId);

            //Based on  ScheduleID the Flight Price Will be Remove(Deleted)
            _flightPrices.Remove(dpri);
            SaveIntoFile();
        }

        /// <summary>
        /// This Method Represents UpdatePrice to Update the FlightPrice Details into List
        /// </summary>
        /// <param name="price"></param>
        public void UpdateFlightPrice(FlightPrice price)
        {
            //Finding the ScheduleId Which Existing in List or not
            FlightPrice upri = _flightPrices.Find(temp => temp.FlightScheduleId == price.FlightScheduleId);

            //Based on the ScheduleId  Business Class seat Price Will be Updating
            upri.PriceForBusinessClassSeat = price.PriceForBusinessClassSeat;

            //Based on the ScheduleId  Business Class seat Price Will be Updating
            upri.PriceForEconomyClassSeat = price.PriceForEconomyClassSeat;
            SaveIntoFile();
        }

        /// <summary>
        /// This Method Represents tO Update the Weekend Hike Percentage Based on Single ScheduleId
        /// </summary>
        /// <param name="price"></param>
        public void UpdateWeekendPriceHikePercentageByScheduleId(FlightPrice price)
        {
            //Finding the ScheduleId Which Existing in List or not
            FlightPrice uwpri = _flightPrices.Find(temp => temp.FlightScheduleId == price.FlightScheduleId);

            //Based on ScheduleId Weekend Price Hike Percentage Will be Updated
            uwpri.WeekendPriceHikePercentage = price.WeekendPriceHikePercentage;
            SaveIntoFile();
        }

        /// <summary>
        /// This Method Represents to Update the Weekend Hike Percentage For All ScheduleId's
        /// </summary>
        /// <param name="weekendPriceHikePercentage"></param>
        public void UpdateWeekendPriceHikePercentageForAllSchedules(double weekendPriceHikePercentage)
        {
            //Updating Hike For all Schedule Id's
            foreach (FlightPrice pri in _flightPrices)
            {
                pri.WeekendPriceHikePercentage = weekendPriceHikePercentage;
            }
            SaveIntoFile();
        }

        /// <summary>
        /// This Method Represents to Get the FlightPrices Based on Before Days
        /// </summary>
        /// <returns>_priceDataAccessLayer</returns>
        public List<FlightPrice> GetFlightPricesByBeforeDays()
        {
            return _flightPrices;
        }
    }
}*/