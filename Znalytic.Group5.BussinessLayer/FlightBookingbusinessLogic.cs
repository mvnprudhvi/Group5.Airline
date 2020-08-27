
// 



using System;



using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;

namespace Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer
{
   
        public class FlightBookingbusinessLogicLayer : _FlightBookingbusinessLogicLayer();
            {
            private FlightBookingDataAcessLayer _fbdal = null;

            public FlightBookingbusinessLogicLayer()
            {
                _fbdal = new FlightBookingDataAcessLayer();
            }

            
            public void  AddBooking(Booking Booking)
            {
                if (Booking.bookingId != null)
                {
                _fbdal.AddBooking(Booking);
                }
                else
                {
                    throw new Exception("booking id can't be null");
                }
            }




        }
    }
