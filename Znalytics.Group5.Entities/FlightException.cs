using System;

namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// Exception class For Flight 
    /// </summary>
    public class FlightException : ApplicationException
    {

        /// <summary>
        /// Exception which Calls the Parent Exception
        /// </summary>
        public FlightException() : base()
        {
        }

        /// <summary>
        /// Exception is displayed With user defined Message
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        public FlightException(string message) : base(message)
        {
        }

        /// <summary>
        /// Inner exception thrown from another layer and re thrown to another layer
        /// </summary>
        /// <param name="message">base Exception message</param>
        /// <param name="innerException">inner exception message</param>
        public FlightException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
