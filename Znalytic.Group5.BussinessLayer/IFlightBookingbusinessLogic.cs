using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightBooking.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    public interface IFlightBookingBusinessLogicLayer
    {
        /// <summary>
        /// this method is to add flightbooking details to the list
        /// </summary>
        /// <param name="bookingID"></param>

        void AddFlightBooking(FlightBooking bookingID);
        
        //this method represents get FlightBooking by booking id
        List<FlightBooking> GetFlightBookingsByBookingID(int bookingID);
        //this method represents get FlightBooking by customer id
        List<FlightBooking> GetFlightBookingsByCustomerID(int customerID);
        //this method represents get FlightBooking by flight id
        List<FlightBooking> GetFlightBookingsByFlightID(int flightID);
       
         List<FlightBooking> GetFlightBookings();



            
    }
}
