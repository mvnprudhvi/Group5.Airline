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
        private int _flightId { set; get; }
        private string _passengerName { set; get; }
        private int _seatNumber { set; get; }
       private int _bookingId { set; get; }

        // constructor 
        public FlightBooking(string flightName, int flightId, string passengerName, int seatNumber, int bookingId)
            {
                _flightName = flightName;
                _flightId = flightId;
                _passengerName = passengerName;
                _seatNumber = seatNumber;
                _bookingId = bookingId;
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

            public int flightId
            {
            // set the value


            set
            {
                    _flightId = value;
                }
            // get the value
                get
                {
                    return _flightId;
                }
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

            public int SeatNumber
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

        public int bookingid
        {
            set
            {

                _bookingId = value;
            }
            get { return _bookingId; }
           }



    }
}



