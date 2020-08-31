
// created by reshma
// BusinessLogicLayer
// Module:FlightBooking

using System;
using Znalytics.Group5.Airline.FlightBookingModule.Entities;


using System.Collections.Generic;
using Znalytics.Group5.DataAccessLayer;
using Znalytics.Group5.FlightBookingModule.DataAccessLayer;

namespace Znalytic.Group5.Airline.FlightBookingModule.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of FlightBooking
    /// </summary>
    public class FlightBookingbusinessLogic : IFlightBookingbusinessLogic
    {
        //Created an object for DataAccessLayer and strore the object in reference variable
        FlightBookingDataAccessLayer fbdl = new FlightBookingDataAccessLayer();

        public bool checkFlightBookingId(string bookingId)
        {
            List<FlightBooking> _bookingList = new List<FlightBooking>();
            // Flight flight = new Flight();
            bool result = _bookingList.Exists(temp => temp.bookingId == bookingId);
            return result;
        }
       
        /// <summary>
        /// This Method Represents AddFlightBooking
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddFlightBooking(FlightBooking bookingId)
        {
            if (FlightBooking.bookingId != 0)
            {
                fbdl.AddFlightBooking(bookingId);
            }
            else
            {
                throw new Exception("bookingId can't be null");
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
        
        public List<FlightBooking> GetFlightBookingsByBookingID(int bookingID)
        {
            return fbdl.GetFlightBookingsByBookingID(bookingID);
           
        }
        //method to get FlightBooking by  customerid
        public List<FlightBooking> GetFlightBookingsByCustomerID(int customerID)
        {
            return fbdl.GetFlightBookingsByCustomerID(customerID);
            

        }


        //method to get FlightBooking by  flightid
        public List<FlightBooking> GetFlightBookingsByFlightID(int flightID)
        {
            return fbdl.GetFlightBookingsByFlightID(flightID);
            
        }

        /// <summary>
        /// This Method Represents GetbookingId 
        /// </summary>
        /// <returns>FlightBookingDataAccessLayer</returns>
        public List<FlightBooking> GetFlightBookings(int bookingID)
        {
            return fbdl.GetFlightBookings(bookingID);
        }

    }

}



