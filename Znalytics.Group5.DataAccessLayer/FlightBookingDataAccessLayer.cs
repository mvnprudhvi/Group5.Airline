// created by Reshma
// DataAccessLayer
//module:FlightBooking




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightBooking.Entities;

namespace Znalytics.Group5.DataAccessLayer
{



    /// <summary>
    /// Represents Business logic layer of the FlightBooking details
    /// </summary>
    class FlightBookingDataAccessLayer : IFlightBookingDataAccessLayer
    {
        private static List<FlightBooking>BookingID
        {
            set;
            get;
        }
        //constructor

        static FlightBookingDataAccessLayer()
        {

            BookingID = new List<FlightBooking>()
            {

           new FlightBooking() { flightID="12", customerID = "12345", bookingID = "67890", seatNumber = "01"},
          new FlightBooking() { flightID="13", customerID = "5678", bookingID = "78901", seatNumber = "02 "  },
          new FlightBooking() { flightID="14",  customerID = "8901", bookingID = "8760", seatNumber = "03 "}
            };
        }
        //methods to add FlightBooking
        public void AddFlightBooking(FlightBooking bookingID)
        {
            if (BookingID.Exists(temp => temp.customerID == bookingID.customerID))
            {
                BookingID.Add(bookingID);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //methods to update  FlightBooking
        public void UpdateFlightBooking(FlightBooking BookingID)
        {
            if (BookingID.Exists(temp => temp.customerID == bookingId.customerID))
            
            {
               BookingID.Update(BookingID);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //method to get  FlightBooking by  Flight Bookingid
        public FlightBooking GetFlightBookingsByFlightBookingID(int BookingID)
        {
            return BookingID.Find(temp => temp.BookingID == BookingID);
        }
        //method to get  FlightBooking by  customer id
        public FlightBooking GetFlightBookingsByFlightCustomerID(int customerID)
        {
            return customerID.Find(temp => temp.customerID == customerID);
        }
        //method to get  FlightBookinging by  flightid
        public FlightBooking GetFlightBookingsByFlightID(int FlightID)
        {
            return FlightID.Find(temp => temp.FlightID == FlightID);
        }
    }
}



 /*/// <summary>
/// Represents  class of flightbooking
/// </summary>

class FlightBookingDataAccessLayer : IFlightBookingDataAccessLayer
    {
        // creating  list
        private static List<FlightBooking> _FlightBooking = new List<FlightBooking>();

        //adding  bookingid
        public void AddFlightBooking(FlightBooking bookingID)
        {
            _FlightBooking.Add(bookingID);
        }
       
        // get  all bookings
        public List<FlightBooking> GetBookings()
        {
            return _bookings;
        }
  
        public void UpdateFlightBooking(FlightBooking CustomerID)
        {
            {
                //Get matching FlightBooking based on CustomerId
                FlightBooking fb = FlightBooking.Find(temp => temp.CustomerID == customer.CustomerID);
                if (CustomerID != null)

                    FlightBooking.CustomerID = FlightBooking.CustomerID;
            }
        }

        public FlightBooking GetFlightBookingsByFlightBookingID(int FlightBookingID)
        {

        }
        public FlightBooking GetFlightBookingsByFlightID(int FlightID)
        {

        }


    }
}*/

