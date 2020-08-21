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
        private static List<Price> _prices;

        //constructor for  Data Access Layer
        static PriceDataAccessLayer()
        {
            _prices = new List<Price>();
        }

        /// <summary>
        /// This Method Represents AddPrice
        /// </summary>
        /// <param name="price"></param>
        public void AddPrice(Price price)
        {
            _prices.Add(price);
        }

        /// <summary>
        /// This Method Repreents Delete Price
        /// </summary>
        /// <param name="price"></param>
        public void DeletePrice(Price price)
        {
            //Based on Flight Name the Price Will be deleted 
           _prices.Remove(temp => temp.FlightName == Price.FlightName);

        }

        /// <summary>
        /// This Method Represents UpdatePrice
        /// </summary>
        /// <param name="price"></param>
        public void UpdatePrice(Price price)
        {
             //Based on Flight Name the Price Will be Updated 
            Price pri = _prices.Find(temp => temp.FlightName == price.FlightName);
            if (pri != null)
            {
                pri.FlightPrice = price.FlightPrice;
            }
        }

        /// <summary>
        /// This Method Represents GetPrices
        /// </summary>
        /// <returns>_prices</returns>
        public List<Price> GetPrices()
        {
            return _prices;
        }
    }
}
