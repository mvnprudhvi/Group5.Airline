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
    /// Represents  class of flightbooking
    /// </summary>

    class FlightBookingDataAccessLayer : IFlightBookingDataAccessLayer
    {
        // creating  list
        private static List<FlightBooking> _FlightBooking = new List<FlightBooking>();

        //add booking id
        public void AddFlightBooking(FlightBooking bookingID)
        {
            _FlightBooking.Add(bookingID);
        }

        // get bookings
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
}

