using System;

namespace Znalytics.Group5.Airline.Entities
{    
    /// <summary>
    /// Exception Class For Flight Price
    /// </summary>
     public class FlightPriceException : ApplicationException
     {

            /// <summary>
            /// Exception Which Calls the Parent Exception
            /// </summary>
            public FlightPriceException() : base()
            {

            }

            /// <summary>
            /// Exception is Displayed With user Defined Message
            /// </summary>
            /// <param name="message">Message to be Displayed</param>
            public FlightPriceException(string message) : base(message)
            {

            }

            /// <summary>
            /// Inner Exception thrown from another layer and re throwned to another layer
            /// </summary>
            /// <param name="message">base Exception</param>
            /// <param name="innerException">Inner Exception Message</param>
            public FlightPriceException(string message, Exception innerException) : base(message)
            {

            }
     }
}
