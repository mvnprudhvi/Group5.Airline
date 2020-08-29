
// created by reshma
// BusinessLogicLayer
// Module:FlightBooking

using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer;
using Znalytic.Group5.BussinessLogicLayer;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of FlightBooking
    /// </summary>
    public class FlightBookingbusinessLogicLayer : IFlightBookingbusinessLogicLayer
    {
        private IFlightBookingbusinessLogicLayer _fbbl = null;

        //Constructor for Business Logic Layer
        public FlightBookingbusinessLogicLayer()
        {
            //Creating Object for FlightBookingDataAccessLayer
            _fbbl = new IFlightBookingDataAccessLayer();

        }

        /// <summary>
        /// This Method Represents AddFlightBooking
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddFlightBooking(FlightBooking bookingID)
        {
            if (FlightBooking.bookingID != null)
            {
                _fbbl.AddFlightBooking(bookingID);
            }
            else
            {
                throw new Exception("bookingId can't be null");
            }
        }

        /// <summary>
        /// This Method Represents Updatation FlightBooking
        /// </summary>
        /// <param name="bookingid"></param>
        public void UpdateFlightBookings(FlightBooking bookingID)
        {
            if (FlightBooking.bookingID != null)
            {
                _fbbl.UpdateFlightBooking(bookingID);
            }
            else
            {
                throw new Exception("booking id can't be null");
            }
        }
        /// <summary>
        /// this Method Represents deletion of flightbooking
        /// </summary>
        /// <param name="fb"></param>

        public void DeleteFlightBooking(FlightBooking fb)
        {
            throw new NotImplementedException();
        }
        //method to get FlightBooking by  bookingid
        public FlightBooking GetFlightBookingsByBookingID(int BookingID)
        {
            return _fbbl.GetBookingID();

        }
        //method to get FlightBooking by  customerid
        public FlightBooking GetFlightBookingsByCustomerID(int CustomerID)
        {
            return _fbbl.GetCustomerID();

        }


        //method to get FlightBooking by  flightid
        public FlightBooking GetFlightBookingsByFlightID(int flightID)
        {
            return _fbbl.GetFlightID();

        }

        /// <summary>
        /// This Method Represents GetbookingId 
        /// </summary>
        /// <returns>FlightBookingDataAccessLayer</returns>
        public List<FlightBooking> GetFlightBooking()
        {
            return _fbbl.GetFlightBooking();
        }

    }

}



