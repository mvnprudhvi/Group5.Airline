
// created by Reshma
//Entities
//module:FlightBooking


using System;
using System.Collections.Generic;


namespace Znalytics.Group5.Airline.FlightBooking.Entities
{
    /// <summary>
    /// Represents  class of flightbooking
    /// </summary>

    public class FlightBooking
    {
        //  represents the private fields
        private string _flightName;

        private int _flightID;
        private string _source;
        private string _destination;
        private string _departureTiming;
        private string -arrivalTiming;
        private string -passengerName;
        private int _customerID;
        private int _bookingID;
        private int _seatNumber;
        private double _price;


        /// <summary>
        /// creating constructor
        /// </summary>
        /// <param name="flightName">represents the name of the flight</param>
        /// <param name="flightID">represents the id of the flight </param>
        /// <param name="source"> represents the FROM location of the flight </param>
        ///  <param name="destination">represents the TO location of the flight </param>
        /// <param name="departureTiming">represents the departure time of the flight</param>
        /// <param name="arrivalTiming">represents the arrving time of the  flight</param>
        /// <param name="passengerName">represents the name of the passenger/param>
        /// <param name="customerID">represents the id of the customer</param>
        /// <param name="bookingID">represents the id of the booking</param>
        /// <param name="seatNumber">represents the seatNumber</param>

        // represents constructor
        public FlightBooking(string flightName, int flightID, string source, string destination, string departureTiming, string arrivalTiming, string passengerName, int customerID, int bookingID, int seatNumber, double price)
        {
           _flightName = flightName;
           _flightID = flightID;
            _source = source;
           _destination = destination;
            _departureTiming = departureTiming;
            _arrivalTiming = arrivalTiming;
            _passengerName = passengerName;
            _customerID = customerID;
            _bookingID = bookingID;
            _seatNumber = seatNumber;
            _price = price;
        }


        // properties
        public string  FlightName
        {
            // set the value
            set
            {
                //Name should be less than 20 string characters
                if (value.Length <= 20)
                {
                    _flightName = value;
                }

                else
                {
                    //throws exception that flightname shuold be 5 digits only
                    throw new Exception("name should not be null");
                }
            }
            get
            {
                return _flightName;
            }

        }
        // get the value

        public int FlightID
        {
            // set the value


            set
            {
                // id of the store should be 5 digits
                if (value <= 5)
                {
                    _flightID = value;

                }
                else
                {
                    throw new Exception(" entered id is invalid id because it should not exceed  5 digits");
                }

            }
            // get the value
            get
            {
                return _flightID;

            }
        }
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


        public string DepartureTiming
        {
            set
            {
                _departureTiming = value;
            }
            get { return _departureTiming; }
        }


        public string ArrivalTiming
        {
            set
            {
                _arrivalTiming = value;
            }
            get { return _arrivalTiming; }
        }

        public string PassengerName
        {
            // set the value

            set
            {
                //Name should be less than 20 string characters
                if (value.Length <= 20)
                {
                    _passengerName = value;
                }
                else
                {
                    //throws exception that bookingid shuold be 5 digits only
                    throw new Exception("passenger  should not exceed 5 digits and it  should not be null");
                }
            }
            // get the value
            get
            {
                return _passengerName;
                    ;
            }
        }

        public int CustomerID
        {
            set
            {
                //id of the customerId should be 5 digits 
                if (value <= 5)
                {
                    _customerID = value;
                }
                else
                {
                    throw new Exception("customer id should not exceed 5 digits");
                }
            }
            get
            {
                return _customerID;
            }
        }

        public int BookingID
        {
            set
            {
                // id of the store should be 5 digits
                if (value <= 5)
                {

                    _bookingID = value;
                }

                else
                {
                    //throws exception that bookingid shuold be 5 digits only
                    throw new Exception("bookingid should not exceed 5 digits");
                }
            }

            // get the value
            get
            {
                return _bookingID;
            }
        }
        public int SeatNumber
        {
            // set the value

            set
            {
                // id of the store should be 5 digits
                if (value <= 5)
                {
                    _seatNumber = value;
                }

                // get the value
                else
                {
                    //throws exception that seatNumber shuold be 5 digits only
                    throw new Exception("seatNumber should not exceed 5 digits and it should not be empty");
                }
            }
            get
            {

                return _seatNumber;
            }
        }
        private double Price
        {
            // set the value
            set
            {
                _price = value;
            }
            get
            {
                return _price;
            }

        }
    }


}


