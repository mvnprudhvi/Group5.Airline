﻿//.......KEERTHANA..........

//Entities
using System;

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

        //constructor
        public FlightSchedule(string FlightScheduleId, string Source, string Destination, DateTime DepartureTiming, DateTime ArrivalTiming)
        {
            _flightScheduleId = flightScheduleId;
            _source = Source;
            _destination = Destination;
            _departureTiming = DepartureTiming;
            _arrivalTiming = ArrivalTiming;
        }

        //properties


        /// <summary>
        /// Default constructor
        /// </summary>
        public FlightSchedule()
        {

        }

        /// <summary>
        /// SHedule id of Flight
        /// </summary>
        public string flightScheduleId
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.StartsWith("FSID") && value.Length <= 4)
                    {
                        _flightScheduleId = value;
                    }
                }
                else

                {
                    throw new System.Exception("invalid flightScheduleid");
                }
            }
            get { return _flightScheduleId; }
        }


        /// <summary>
        /// from adress of flight i.e., Source
        /// </summary>
        public string Source
        {
            set
            {

                _source = value;
            }
            get { return _source; }
        }


        public string Destination
        {
            set
            {

                _destination = value;
            }
            get { return _destination; }
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

    }
}