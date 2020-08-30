/// <summary>
/// Created By Dinesh
/// Module Name is Flight Price
/// </summary>

using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using System.Collections.Generic;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of Price
    /// </summary>
    public class FlightPriceBusinessLogic : IFlightPriceBusinessLogic
    {
        //Reference Variable Of Price Data Access Layer
        private IFlightPriceDataAccessLayer _flightPriceDataAccessLayer;

        /// <summary>
        /// Constructor For Business Logic Layer
        /// </summary>
        public FlightPriceBusinessLogic()
        {
            //Creating Object for Price Data Access Layer
            _flightPriceDataAccessLayer = new FlightPriceDataAccessLayer();
        }

        /// <summary>
        /// This Method Represents AddPrice 
        /// </summary>
        /// <param name="price"></param>
        public void AddFlightPrice(FlightPrice price)
        {
            _flightPriceDataAccessLayer.AddFlightPrice(price);
        }

        public void DeleteFlightPrice(FlightPrice price)
        {
            _flightPriceDataAccessLayer.DeleteFlightPrice(price);
        }

        /// <summary>
        /// This Method Represents UpdatePrice 
        /// </summary>
        /// <param name="price"></param>
        public void UpdateFlightPrice(FlightPrice price)
        {
            _flightPriceDataAccessLayer.UpdateFlightPrice(price);
        }

        /// <summary>
        /// This Method Represents GetPrice 
        /// </summary>
        /// <returns>_priceDataAccessLayer</returns>
        public List<FlightPrice> GetFlightPrices()
        {
            return _flightPriceDataAccessLayer.GetFlightPrices();
        }
    }
}