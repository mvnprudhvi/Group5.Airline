using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using System;
using System.Collections.Generic;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of Price
    /// </summary>
    public class PriceBusinessLogic
    {
        PriceDataAccessLayer _priceDataAccessLayer;

        public PriceBusinessLogic()
        {
            _priceDataAccessLayer = new PriceDataAccessLayer();
        }

        /// <summary>
        /// This Method Represents AddPrice 
        /// </summary>
        /// <param name="price"></param>
        public void AddPrice(Price price)
        {
            if (price.FlightName != null)
            {
                _priceDataAccessLayer.AddPrice(price);
            }
            else
            {
                throw new Exception("Flight Name and Price can't be null");
            }
        }
        public void DeletePrice(Price price)
        {
            _priceDataAccessLayer.DeletePrice(price);
        }

        public void UpdatePrice(Price price)
        {
            if (Price.price != null)
            {
                _priceDataAccessLayer.UpdatePrice(price);
            }
        }

        /// <summary>
        /// This Method Represents GetPrice 
        /// </summary>
        /// <returns></returns>
        public List<Price> GetPrices()
        {
            return _priceDataAccessLayer.GetPrices();
        }
    }
}