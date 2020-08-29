using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.AirLine.Entities
{
    /// <summary>
    /// Class For Customer Exception 
    /// </summary>
    class CustomerException : ApplicationException
    {
        //Constructor That Initializes Nothing
        public CustomerException() : base()
        {

        }

        /// <summary>
        /// Constructor Initializes Only Message
        /// </summary>
        /// <param name="message"></param>
        public CustomerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor initializes Message and InnerException
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception which causes the current exception</param>
        public CustomerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
