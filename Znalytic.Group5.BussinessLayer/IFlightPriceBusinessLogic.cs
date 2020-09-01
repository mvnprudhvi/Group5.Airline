/// <summary>
/// Created By Dinesh
/// Module Name is FlightPrice
/// </summary>

//Importing Statements
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

/// <summary>
/// Created a namespace for Business Logic Layer of Airline Reservation System
/// </summary>
namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    /// This Represents an Interface of FlightPrice Business Logic Layer
    /// It Consists of Following Methods to implement Compulsory
    /// </summary>
    public interface IFlightPriceBusinessLogic
    {
        /// <summary>
        /// This Represents Method Declaration of Add FlightPrice to the Add FlightPrice
        /// </summary>
        /// <param name="price">Represents the object of FlightPrice</param>
        void AddFlightPrice(FlightPrice price);


        /// <summary>
        /// This Represents Method Declaration of Delete FlightPrice to the Delete FlightPrice
        /// </summary>
        /// <param name="price">Represents the object of FlightPrice</param>
        void DeleteFlightPrice(FlightPrice price);


        /// <summary>
        /// This Represents Method Declaration of Update FlightPrice  to Update the FlightPrice 
        /// </summary>
        /// <param name="price">Represents the object of FlightPrice</param>
        void UpdateFlightPrice(FlightPrice price);


        /// <summary>
        /// This Represents Method Declaration of Get FlightPrices Based on Beforedays
        /// </summary>
        /// <param name="beforedays"></param>
        List<FlightPrice> GetFlightPricesByBeforeDays(int beforedays);


        /// <summary>
        /// This Represents Method Declaration of Update Weekend Hike Percentage Based On ScheduleId  
        /// </summary>
        /// <param name="price">Represents the object of FlightPrice</param>
        void UpdateWeekendPriceHikePercentageByScheduleId(FlightPrice price);


        /// <summary>
        /// This Represents Method Declaration of Update Weekend Hike Percentage For All ScheduleId's
        /// </summary>
        /// <param name="weekendPriceHikePercentage"></param>
        void UpdateWeekendPriceHikePercentageForAllSchedules(double weekendPriceHikePercentage);
    }
}
