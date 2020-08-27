// created by Reshma



using System;
using System.Collections.Generic;


namespace Znalytics.Group5.Airline.FlightBooking.Entities
{

    // A class of flightbooking
    public class FlightBooking
    {
        // private fields
        private string _flightName { set; get; }
        private int _flightNumber { set; get; }
        private string _source { set; get; }
        private string _destination { set; get; }
        private string _departureTiming { set; get; }
        private string _arrivalTiming { set; get; }
        private string _passengerName { set; get; }
        private int _bookingId { set; get; }
        private int _seatNumber { set; get; }



        // constructor
        public FlightBooking(string flightName, int flightNumber, string source, string destination, string departureTiming, string arrivalTiming, string passengerName, int bookingId, int seatNumber,)
        {
            _flightName = flightName;
            _flightNumber = flightNumber;
            _source = source;
            _destination = destination;
            _departureTiming = departureTiming;
            _arrivalTiming = arrivalTiming;
            _passengerName = passengerName;
            _bookingId = bookingId;
            _seatNumber = seatNumber;
        }


        // properties
        public string flightName
        {
            // set the value
            set
            {
                _flightName = value;
            }
            // get the value
            get
            {
                return _flightName;
            }
        }

        public int flightNumber
        {
            // set the value


            set
            {
                _flightNumber = value;
            }
            // get the value
            get
            {
                return _flightNumber;

            }
        }
        public string source
        {
            set
            {

                _source = value;
            }
            get { return _source; }
        }


        public string destination
        {
            set
            {

                _destination = value;
            }
            get { return _destination; }
        }


        public string departureTiming
        {
            set
            {
                _departureTiming = value;
            }
            get { return _departureTiming; }
        }


        public string arrivalTiming
        {
            set
            {
                _arrivalTiming = value;
            }
            get { return _arrivalTiming; }
        }

        public string passengerName
        {
            // set the value

            set
            {
                _passengerName = value;
            }
            // get the value
            get
            {
                return _passengerName;
            }
        }



        public int bookingId
        {
            set
            {

                _bookingId = value;
            }
            get
            {
                return _bookingId;
            }
        }
        public int seatNumber
        {
            // set the value

            set
            {
                _seatNumber = value;
            }
            // get the value
            get
            {
                return _seatNumber;
            }
        }

    }

}


