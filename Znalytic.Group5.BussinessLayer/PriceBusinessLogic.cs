/// <summary>
/// Created By Dinesh
/// Module Name is Price
/// </summary>

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
        PriceDataAccessLayer _priceDataAccessLayer;//Reference Variable Of Price Data Access Layer

        //Constructor for Business Logic Layer
        public PriceBusinessLogic()
        {
            _priceDataAccessLayer = new PriceDataAccessLayer();//Creating Object for Price Data Access Layer
        }

        /// <summary>
        /// This Method Represents AddPrice 
        /// </summary>
        /// <param name="price"></param>
        public void AddFlightPrice(Price price)
        {
            _priceDataAccessLayer.AddFlightPrice(price);
        }
        
        public void DeleteFlightPrice(FlightPrice price)
        {
            _priceDataAccessLayer.DeleteFlightPrice(price);
        }

        /// <summary>
        /// This Method Represents UpdatePrice 
        /// </summary>
        /// <param name="price"></param>
        public void UpdateFlightPrice(FlightPrice price)
        {
           _priceDataAccessLayer.UpdateFlightPrice(price);
        }

        /// <summary>
        /// This Method Represents GetPrice 
        /// </summary>
        /// <returns>_priceDataAccessLayer</returns>
        public List<FlightPrice> GetPrices()
        {
            return _priceDataAccessLayer.GetFlightPrices();
        }

        public void AddFlightPrice(FlightPrice price)
        {
            throw new NotImplementedException();
        }
    }
}