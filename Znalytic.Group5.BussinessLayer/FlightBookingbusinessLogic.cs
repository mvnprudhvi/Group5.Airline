
// created by reshma

using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of FlightBooking
    /// </summary>
    public class FlightBookingBusinessLogicLayer : IFlightBookingBusinessLogicLayer
    {
        private IFlightBookingBusinessLogicLayer _fbal = null;

        //Constructor for Business Logic Layer
        public FlightBookingBusinessLogicLayer()
        {
            //Creating Object for FlightBookingData Access Layer
            _fbdal = new IFlightBookingDataAccessLayer();

        }

        /// <summary>
        /// This Method Represents AddFlightBooking
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddFlightBooking(FlightBooking bookingID)
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

        /// <summary>
        /// This Method Represents Update FlightBooking
        /// </summary>
        /// <param name="bookingid"></param>
        public void UpdateFlightBookings(FlightBooking bookingID)
        {
            if (FlightBooking.bookingID != null)
            {
                _fbdal.UpdateFlightBooking(bookingID);
            }
            else
            {
                throw new Exception("booking id can't be null");
            }
        }
        //method to get ticket cancellation by  customer id
        public FlightBooking GetFlightBookingsByCustomerID(int _customerID)
        {
            return _fbdal.GetcustomerID();

        }

        public void DeleteFlightBooking(FlightBooking tc)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// This Method Represents GetbookingId 
    /// </summary>
    /// <returns>FlightBookingDataAccessLayer</returns>
    public List<FlightBooking> GetFlightBooking()
    {
        return _fbdal.GetFlightBooking();
    }

}




