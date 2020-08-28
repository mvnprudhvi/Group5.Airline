
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
        private string FlightName;

        private int FlightID;
        private string Source;
        private string Destination;
        private string DepartureTiming;
        private string ArrivalTiming;
        private string PassengerName;
        private int CustomerID;
        private int BookingID;
        private int SeatNumber;
        private double price;


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
            this.FlightName = flightName;
            this.FlightID = flightID;
            this.Source = source;
            this.Destination = destination;
            this.DepartureTiming = departureTiming;
            this.ArrivalTiming = arrivalTiming;
            this.PassengerName = passengerName;
            this.CustomerID = customerID;
            this.BookingID = bookingID;
            this.SeatNumber = seatNumber;
            this.price = price;
        }


        // properties
        public string flightName
        {
            // set the value
            set
            {
                //Name should be less than 20 string characters
                if (value.Length <= 20)
                {
                    flightName = value;
                }

                else
                {
                    //throws exception that flightname shuold be 5 digits only
                    throw new Exception("name should not be null");
                }
            }
            get
            {
                return flightName;
            }

        }
        // get the value

        public int flightID
        {
            // set the value


            set
            {
                // id of the store should be 5 digits
                if (value <= 5)
                {
                    flightID = value;

                }
                else
                {
                    throw new Exception(" entered id is invalid id because it should not exceed  5 digits");
                }

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
                //Name should be less than 20 string characters
                if (value.Length <= 20)
                {
                    passengerName = value;
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
                return passengerName;
            }
        }

        public int customerID
        {
            set
            {
                //id of the customerId should be 5 digits 
                if (value <= 5)
                {
                    customerID = value;
                }
                else
                {
                    throw new Exception("customer id should not exceed 5 digits");
                }
            }
            get
            {
                return customerID;
            }
        }

        public int bookingID
        {
            set
            {
                // id of the store should be 5 digits
                if (value <= 5)
                {

                    bookingID = value;
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
                return bookingID;
            }
        }
        public int seatNumber
        {
            // set the value

            set
            {
                // id of the store should be 5 digits
                if (value <= 5)
                {
                    seatNumber = value;
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

                return seatNumber;
            }
        }
        private double Price
        {
            // set the value
            set
            {
                price = value;
            }
            get
            {
                return price;
            }

        }
    }


}


