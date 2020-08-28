

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
    /// <summary>
    /// This Class Represents Business Logic Layer Of FlightBooking
    /// </summary>     


    public class FlightBookingbusinessLogic : IFlightBookingbusinessLogic();
            {
        //Constructor for Business Logic Layer
        private IFlightBookingDataAccessLayer _fbdal = null;

        public FlightBookingbusinessLogic()
        {
            _fbdal = new FlightBookingDataAccessLayer();//Creating Object for FlightBooking Data Access Layer
        }

        /// <summary>
        /// This Method Represents Adding bookingid for flightbooking
        /// </summary>
        /// <param name="bookingID"></param>
        public void AddFlightBooking(int bookingID)
        {
            if (FlightBooking.bookingID != null)
            {
                _fbdal.AddFlightBooking(bookingID);
            }
            else
            {
                throw new Exception("bookingId can't be null");
            }
        }

        public void UpdateFlightBooking(int  bookingID)
        {
            if (FlightBooking.BookingID != null)
            {
                _fbdal.UpdateFlightBooking(bookingID);
            }
            else
            {
                throw new Exception("customerid can't be null");
            }
        }
        //method to get FlightBooking by customer id
        public FlightBooking GetFlightBookingsByCustomerID(int customerID)
        {
        }


        public FlightBooking GetFlightBookingsByFlightBookingID(int BookingID)
        {
            

        }
        public FlightBooking GetFlightBookingsByFlightID(int FlightID)
        {
           
        }

    }
}