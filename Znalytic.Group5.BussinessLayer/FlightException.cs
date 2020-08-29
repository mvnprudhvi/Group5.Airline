//Importing Statements
using System;
using System.Runtime.Serialization;

namespace Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer
{
    [Serializable]
    internal class FlightException : Exception
    {
        public FlightException()
        {
        }

        public FlightException(string message) : base(message)
        {
        }

        public FlightException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FlightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}