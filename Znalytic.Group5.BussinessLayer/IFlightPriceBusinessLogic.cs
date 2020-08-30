using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    ///  Interface For Flight Price Data Access Layer Consists of Following Methods to implement
    /// </summary>
    public interface IFlightPriceBusinessLogic
    {
        /// <summary>
        /// This Represents Declaration of Add Flight Price Method
        /// </summary>
        /// <param name="price"></param>
        void AddFlightPrice(FlightPrice price);

        /// <summary>
        /// This Represents Declaration of Delete Flight Price Method
        /// </summary>
        /// <param name="price"></param>
        void DeleteFlightPrice(FlightPrice price);

        /// <summary>
        /// This Represents Declaration of Update Flight Price Method
        /// </summary>
        /// <param name="price"></param>
        void UpdateFlightPrice(FlightPrice price);

        /// <summary>
        /// This Represents Declaration of Get Flight Price Method
        /// </summary>
        /// <param name="price"></param>
        List<FlightPrice> GetFlightPrices();
    }
}
