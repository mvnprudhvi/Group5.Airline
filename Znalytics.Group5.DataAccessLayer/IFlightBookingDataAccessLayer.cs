// created by Reshma
// IDataAccessLayer
//module:FlightBooking




using Znalytics.Group5.Airline.FlightBooking.Entities;

namespace Znalytics.Group5.DataAccessLayer
{
    internal interface IFlightBookingDataAccessLayer
    {
        void AddFlightBooking(FlightBooking bookingID);

        void UpdateFlightBooking(FlightBooking CustomerID);
        
    }