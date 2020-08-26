/// <summary>
/// Created By Dinesh
/// Module Name is Price
/// </summary>

using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    /// <summary>
    /// This Class Represents Data Access Layer Of Price
    /// </summary>
    public class PriceDataAccessLayer
    {
        //private Field of price Collection
        private static List<FlightPrice> _flightPrices;

        //constructor for  Data Access Layer
        static PriceDataAccessLayer()
        {
            _flightPrices = new List<FlightPrice>();
        }

        /// <summary>
        /// This Method Represents AddPrice
        /// </summary>
        /// <param name="price"></param>
        public void AddFlightPrice(FlightPrice price)
        {
            _flightPrices.Add(price);
        }

        /// <summary>
        /// This Method Repreents Delete Price
        /// </summary>
        /// <param name="price"></param>
        public void DeleteFlightPrice(FlightPrice price)
        {
            //Based on Flight Name the Price Will be deleted 
            _flightPrices.Remove(temp => temp.ScheduleNumber==price.ScheduleNumber);

        }

        /// <summary>
        /// This Method Represents UpdatePrice
        /// </summary>
        /// <param name="price"></param>
        public void UpdateFlightPrice(FlightPrice price)
        {
            //Based on Flight Name the Price Will be Updated 
                 Price pri = _flightPrices.Find(temp => temp.ScheduleNumber == price.ScheduleNumber);
                pri.Price = price.Price;
        }

        /// <summary>
        /// This Method Represents GetPrices
        /// </summary>
        /// <returns>_prices</returns>
        public List<FlightPrice> GetFlightPrices()
        {
            return _flightPrices;
        }
    }
}