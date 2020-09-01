/*using System;
using System.Runtime.Serialization;
using Znalytics.Group5.AirLine.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.AirLine.Entities
{
    /// <summary>
    /// Class For Customer Exception 
    /// </summary>
   public class CustomerException : ApplicationException
    {
        /// <summary>
        ///  Exception Is Displayed With User Defined Message
        /// </summary>
        /// <param name="message"></param>
        public CustomerException(string message) : base(message)
        {

        }
        /// <summary>
        /// Inner Exception Thrown By  Other Layer & Rethrown To Another Layer
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception which causes the current exception</param>
        public CustomerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
