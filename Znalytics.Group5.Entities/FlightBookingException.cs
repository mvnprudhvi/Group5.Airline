/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.Entities
{
   public  class FlightBookingException : ApplicationException
    {


        /// <summary>
        /// exception is displayed with user defined message
        /// </summary>
        /// <param name="message"></param>
       
        public FlightBookingException(string message) : base(message)
        {

        }
        /// <summary>
        /// inner Exception thrown by  other layer & rethrown to another layer
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public FlightBookingException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
