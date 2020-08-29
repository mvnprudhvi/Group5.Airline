
// created by reshma





using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of ticket cancellation
    /// </summary>
    public class FlightBookingBusinessLogicLayer : IFlightBookingBusinessLogicLayer
    {
        private IFlightBookingBusinessLogicLayer _fb = null;

        //Constructor for Business Logic Layer
        public FlightBooking()
        {
            //Creating Object for ticket cancellation Data Access Layer
            _fb = new IFlightBookingFlightBookingDataAccessLayer();

        }

        /// <summary>
        /// This Method Represents AddTicketCancellation 
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddFlightBooking(FlightBooking bookingID)
        {
            if (FlightBooking.bookingID != null)
            {
                _tcdal.AddFlightBooking(bookingID);
            }
            else
            {
                throw new Exception("bookingId can't be null");
            }
        }

        /// <summary>
        /// This Method Represents Update ticket cancellation
        /// </summary>
        /// <param name="bookingid"></param>
        public void UpdateFlightBooking(FlightBooking bookingID)
        {
            if (FlightBooking.bookingID != null)
            {
                _fb.UpdateFlightBooking(bookingID);
            }
            else
            {
                throw new Exception("booking id can't be null");
            }
        }
        //method to get ticket cancellation by ticket customer id
        public FlightBooking GetFlightBookingByCustomerID(int _customerID)
        {
            return _fb.GetcustomerID();

        }

        public void DeleteFlightBooking(FlightBooking fb)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// This Method Represents GetbookingId 
    /// </summary>
    /// <returns>TicketCancellationDataAccessLayer</returns>
    public List<FlightBooking> GetFlightBooking()
    {
        return _fb.GetFlightBooking();
    }

}

 