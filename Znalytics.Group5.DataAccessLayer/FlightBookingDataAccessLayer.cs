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
        private static List<FlightBooking>_bookingID
        {
            set;
            get;
        }
        //constructor

       
                static FlightBookingDataAccessLayer()
                {

                    _bookingID = new List<FlightBooking>()
                    {

          new FlightBooking() { FlightID = 12, CustomerID = 12345, BookingID = 67890, SeatNumber = 01, Source = "hyderabad", Destination  = "Mumbai"},
          new FlightBooking() { FlightID = 13, CustomerID = 5678, BookingID  = 78901, SeatNumber = 02, Source = "Mumbai", Destination  = "chennai"},
          new FlightBooking() { FlightID = 14,  CustomerID = 8901, BookingID  = 8760, SeatNumber = 03,Source = "pune", Destination  = "Hyderabad" }
            };
        }
        //methods to add FlightBooking
        public void AddFlightBooking(FlightBooking bookingID)
        {
            if (_bookingID.Exists(temp => temp.CustomerID == bookingID.CustomerID))
            {
                _bookingID.Add(bookingID);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //methods to update  FlightBooking
        public void UpdateFlightBooking(FlightBooking bookingID)
        {
            if (_bookingID.Exists(temp => temp.CustomerID == bookingID.CustomerID))
            
            {
               _bookingID.Update(bookingID);
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
            return _bookingID.Find(temp => temp.BookingID == BookingID);
        }
        //method to get  FlightBooking by  customer id
        public FlightBooking GetFlightBookingsByFlightCustomerID(int CustomerID)
        {
            return _customerID.Find(temp => temp.customerID == CustomerID);
        }
        //method to get  FlightBookinging by  flightid
        public FlightBooking GetFlightBookingsByFlightID(int flightID)
        {
            return _flightID.Find(temp => temp.FlightID == FlightID);
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

