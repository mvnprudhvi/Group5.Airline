using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightBooking.Entities;

namespace Znalytics.Group5.DataAccessLayer
{
    class FlightBookingDataAcessLayer
    {
 

            // create list
            private static List<FlightBooking> _flights = new List<FlightBooking>();

            //add booking id
            public void AddbookingId(FlightBooking bookingId)
            {
                _flights.Add(bookingId);
            }

       // get booking id
        public List<FlightBooking> GetbookingId()
        {
            return _bookingId;
        }

        // add seatnumber
        public void AddseatNumber(FlightBooking seatNumber)
        {
            _flights.Add(seatNumber);
        }
        // get seatnumber

        public List<FlightBooking> GetseatNumber()
        {
            return _seatNumber;
        }
    }
}
