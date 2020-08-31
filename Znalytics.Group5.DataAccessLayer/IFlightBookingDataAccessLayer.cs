// created by Reshma
// IDataAccessLayer
//module:FlightBooking




using Znalytics.Group5.Airline.FlightBooking.Entities;

namespace Znalytics.Group5.DataAccessLayer
{
    internal interface IFlightBookingDataAccessLayer
    {
        /// <summary>
        /// method to add bookingId
        /// </summary>
        /// <param name="bookingID"></param>
        void AddFlightBooking(FlightBooking bookingID);
        /// <summary>
        /// method to updatation of customerId
        /// </summary>
        /// <param name="CustomerID"></param>
        void UpdateFlightBooking(FlightBooking CustomerID);


        //method to get  FlightBooking by  Flight Bookingid
        FlightBooking GetFlightBookingsByFlightBookingID(int bookingID);

        //method to get  FlightBooking by  customer id
        FlightBooking GetFlightBookingsByFlightCustomerID(int customerID);

        //method to get  FlightBookinging by  flightid
        FlightBooking GetFlightBookingsByFlightID(int flightID);

    }
}











