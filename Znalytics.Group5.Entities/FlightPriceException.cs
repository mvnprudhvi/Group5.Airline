using System;

namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// Exception Class For Flight Price
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
        /// Inner Exception thrown from another layer and re throwned to another layer
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner Exception Which Cause the Current Exception</param>
        public FlightPriceException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
