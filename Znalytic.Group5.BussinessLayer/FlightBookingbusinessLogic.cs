
// 



using System;



using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;

namespace Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer
{
   
        public class FlightBookingbusinessLogicLayer : IFlightBookingbusinessLogicLayer();
            {
            private FlightBookingDataAcessLayer _fbdal = null;

            public FlightBookingbusinessLogicLayer()
            {
                _fbdal = new FlightBookingDataAcessLayer();
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




        }
    }
