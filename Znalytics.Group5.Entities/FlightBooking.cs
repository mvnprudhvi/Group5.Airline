// created by Reshma



using System;
using System.Collections.Generic;


namespace Znalytics.Group5.Airline.FlightBooking.Entities
{

    // A class of flightbooking

    public class FlightBooking 
    {
        //  represents the private fields
        private string FlightName;
  
        private int FlightID;
        private string Source;
        private string Destination;
        private string DepartureTiming;
        private string ArrivalTiming;
        private string PassengerName;
        private int  CustomerID;
        private int BookingID;
        private int   SeatNumber;

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

        // constructor
        public FlightBooking(string flightName, int flightID, string source, string destination, string departureTiming, string arrivalTiming, string passengerName, int customerID, int  bookingID, int seatNumber)
        {
           this.FlightName = flightName;
           this.FlightID = flightID;
            this.Source = source;
            this.Destination = destination;
           this. DepartureTiming = departureTiming;
            this.ArrivalTiming = arrivalTiming;
            this.PassengerName = passengerName;
            this.CustomerID = customerID;
           this. BookingID = bookingID;
            this.SeatNumber = seatNumber;
        }


        // properties
        public string flightName
        {
            // set the value
            set
            {
                flightName = value;
            }
            // get the value
            get
            {
                return flightName;
            }
        }

        public string flightID
        {
            // set the value


            set
            {
                flightID= value;
            }
            // get the value
            get
            {
                return flightID;

            }
        }
        public string source
        {
            set
            {

                source = value;
            }
            get { return source; }
        }


        public string destination
        {
            set
            {

                destination = value;
            }
            get { return destination; }
        }


        public string departureTiming
        {
            set
            {
                departureTiming = value;
            }
            get { return departureTiming; }
        }


        public string arrivalTiming
        {
            set
            {
                arrivalTiming = value;
            }
            get { return arrivalTiming; }
        }

        public string passengerName
        {
            // set the value

            set
            {
                passengerName = value;
            }
            // get the value
            get
            {
                return passengerName;
            }
        }



        public string bookingID
        {
            set
            {

                bookingID= value;
            }
            get
            {
                return bookingID;
            }
        }
        public string seatNumber
        {
            // set the value

            set
            {
                seatNumber = value;
            }
            // get the value
            get
            {
                return seatNumber;
            }
        }

    }

}


