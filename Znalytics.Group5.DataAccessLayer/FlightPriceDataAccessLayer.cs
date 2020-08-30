/// <summary>
/// Created By Dinesh
/// Module Name is Flight Price
/// </summary>

using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    /// <summary>
    /// This Class Represents Data Access Layer Of Price
    /// </summary>
    public class FlightPriceDataAccessLayer
    {
        //private Field of price Collection
        private static List<FlightPrice> _flightPrices;

        //constructor for  Data Access Layer
        static FlightPriceDataAccessLayer()
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
            //Based on  ScheduleID the Price Will be deleted 
            FlightPrice dpri = _flightPrices.Find(temp => temp.FlightScheduleId == price.FlightScheduleId);
            _flightPrices.Remove(dpri);
        }

        /// <summary>
        /// This Method Represents UpdatePrice
        /// </summary>
        /// <param name="price">This is a object of Flight Price</param>
        public void UpdateFlightPrice(FlightPrice price)
        {
            //Based on ScheduleID the Price Will be Updated 
            FlightPrice upri = _flightPrices.Find(temp => temp.FlightScheduleId == price.FlightScheduleId);
            upri.PriceForBusinessClassSeat = price.PriceForBusinessClassSeat;
            upri.PriceForEconomyClassSeat = price.PriceForEconomyClassSeat;
        }

        /// <summary>
        /// This Method Represents GetPrices
        /// </summary>
        /// <returns>_flightprices</returns>
        public List<FlightPrice> GetFlightPrices()
        {
            return _flightPrices;
        }
        /// <summary>
        /// This Method Represents GetPrices
        /// </summary>
        /// <returns>_prices</returns>
    }
}