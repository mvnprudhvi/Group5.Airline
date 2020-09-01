//.......KEERTHANA..........

//Entities
/*using System;
using System.Text.RegularExpressions;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.FlightScheduleModule.Entities
{

    // creating a class "FlightSchedule"
    public class FlightSchedule

    {
        //Private Fields
        private string _flightScheduleId { set; get; }
        private string _source { set; get; }
        private string _destination { set; get; }
        private DateTime _departureTiming { set; get; }
        private DateTime _arrivalTiming { set; get; }

        //flightId Property
        public string flightId;
        public string flightScheduleId;

        //constructor
        public FlightSchedule(string flightScheduleId, string source, string destination, DateTime departureTiming, DateTime arrivalTiming)
        {
            _flightScheduleId = flightScheduleId;
            _source = source;
            _destination = destination;
            _departureTiming = departureTiming;
            _arrivalTiming = arrivalTiming;
        }

        //properties


        /// <summary>
        /// Default constructor
        /// </summary>
        public FlightSchedule()
        {

        }

        /// <summary>
        /// Schedule id of Flight
        /// </summary>
        public string FlightScheduleId
        {
                set
                {
                    //Regular Expression for AlphaNumeric values
                    Regex r = new Regex("^[A-Z0-9]+$");
                    //flightId should not be null or empty
                    if (!string.IsNullOrEmpty(value) && value.StartsWith("FSID") && r.IsMatch(value) && value.Length == 6)
                    {


                        _flightScheduleId = value;

                    }

                    else
                    {
                        throw new FlightException("Enter valid flightScheduleId.It should not contain spaces and length be exactly 6");
                    }
                }
                get
                {
                    return _flightScheduleId;

                }
            }
        


        /// <summary>
        /// from adress of flight i.e., Source
        /// </summary>
        public string Source
        {
            set
            {
                //Regular Expression for Alphabets(Capital&small letters)
                Regex r = new Regex("[a-zA-Z_]+$");
                //LocationName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                {

                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _source = value;
                    }

                }

                else
                {
                    throw new FlightException("destination shouldn't be null and shouldn't contain special characters");
                }
            }
            get
            {
                return _source;
            }
        }


        public string Destination
        {
            set
            {
                //Regular Expression for Alphabets(Capital&small letters)
                Regex r = new Regex("[a-zA-Z_]+$");
                //LocationName should not be null or empty
                if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
                {
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _destination = value;
                    }
                }

                else
                {
                    throw new FlightException("Destination shouldn't be null and shouldn't contain special characters");
                }
            }
            get
            {
                return _destination;
            }
        }


        public DateTime DepartureTiming
        {
            set
            {
                _departureTiming = value;
            }
            get { return _departureTiming; }
        }


        public DateTime ArrivalTiming
        {
            set
            {
                _arrivalTiming = value;
            }
            get { return _arrivalTiming; }
        }

        public string FlightId { get; set; }
    }
}