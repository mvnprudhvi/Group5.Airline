using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.Airline.Entities
{
    public class FlightException : ApplicationException
    {
        /// <summary>
        /// exception calls parent exception
        /// </summary>
        public FlightException() :base()
        {

        }
        /// <summary>
        /// exception is displayed with user defined message
        /// </summary>
        /// <param name="message"></param>
        public FlightException(string message) : base(message)
        {

        }
        /// <summary>
        /// inner Exception thrown by  other layer & rethrown to another layer
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public FlightException(string message, Exception innerException) : base(message, innerException)
        {
        }
       

    }
}
