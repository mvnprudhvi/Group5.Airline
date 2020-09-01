/// <summary>
/// Created By Dinesh
/// Module Name is FlightPrice
/// </summary>

//Importing Statement
using System;

/// <summary>
/// Created a namespace for Entity Layer of Airline Reservation System
/// </summary>
namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// Exception Class For FlightPrice
    /// </summary>
    public class FlightPriceException : ApplicationException
    {
        /// <summary>
        /// Constructor initializes Nothing
        /// Exception Which Calls the Parent Exception
        /// </summary>
        public FlightPriceException() : base()
        {
        }

        /// <summary>
        /// Constructor initializes only Message
        /// Exception is Displayed With user Defined Message
        /// </summary>
        /// <param name="message">Message to be Displayed</param>
        public FlightPriceException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor initializes Message and InnerException
        /// Inner Exception thrown from another place and re throwned to another place
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner Exception Which Cause the Current Exception</param>
        public FlightPriceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
