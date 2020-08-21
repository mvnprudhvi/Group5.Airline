using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public class PriceDataAccessLayer
    {
        //private fields
        private static List<Price> _prices;

        //constructor
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
        public void DeletePrice(Price price)
        {
            _prices.Remove(tem => tem.price == Price.price);

        }


        /// <summary>
        /// This Method Represents UpdatePrice
        /// </summary>
        /// <param name="price"></param>
        public void UpdatePrice(Price price)
        {
            //Get matching Flightname based on FLIGHTID
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
