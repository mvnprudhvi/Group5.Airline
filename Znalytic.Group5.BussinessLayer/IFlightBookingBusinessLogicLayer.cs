namespace Znalytic.Group5.BussinessLogicLayer
{
    public interface IFlightBookingBusinessLogicLayer
    {
        /this method represents add FlightBooking
        public void FlightBooking(FlightBooking FlightBooking);

        //this method represents update FinglightBooking
        public void UpdateFlightBooking(FlightBooking FlightBooking);

        //this method represents get FlightBooking by customer id
        public FlightBooking GetFlightBookingByCustomerID(int _customerID);

        //this method represents delete FlightBooking
        public void DeleteFlightBooking(FlightBooking fb);
    }
}
}