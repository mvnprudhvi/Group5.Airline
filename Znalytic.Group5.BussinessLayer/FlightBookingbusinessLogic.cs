

// created by Reshma
// BusinessLogicLayer
// module:  FlightBooking



using System;



using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;

namespace Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer
{
   
        public class FlightBookingbusinessLogicLayer : IFlightBookingbusinessLogicLayer();
            {
            private FlightBookingDataAccessLayer _fbdal = null;

            public FlightBookingbusinessLogicLayer()
            {
                _fbdal = new FlightBookingDataAccessLayer();
            }

            
            public void  AddBookingId(FlightBooking BookingId)
            {
                if (FlightBooking.bookingId != null)
                {
                _fbdal.AddBooking(BookingId);
                }
                else
                {
                    throw new Exception("booking id can't be null");
                }
            }
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
