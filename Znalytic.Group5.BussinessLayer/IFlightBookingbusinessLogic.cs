using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
     interface IFlightBookingbusinessLogicLayer
    {
        /// <summary>
        /// this method is to add flightbooking details to the list
        /// </summary>
        /// <param name="bookingID"></param>

        void AddFlightBooking(FlightBooking bookingID);
        
        //this method represents get FlightBooking by booking id
        FlightBooking GetFlightBookingsByBookingID(int bookingID);

        //this method represents get FlightBooking by customer id
       FlightBooking GetFlightBookingsByCustomerID(int customerID);

        //this method represents get FlightBooking by flight id
       FlightBooking GetFlightBookingsByFlightID(int flightID);

       // this methods gets all bookings of flight
         FlightBooking  GetFlightBookings();



            
    }
}
