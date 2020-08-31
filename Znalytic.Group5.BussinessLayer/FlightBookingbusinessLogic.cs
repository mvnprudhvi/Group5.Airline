/*
// created by reshma
// BusinessLogicLayer
// Module:FlightBooking

using System;
using Znalytics.Group5.Airline.Entities;

using System.Collections.Generic;
using Znalytics.Group5.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;



namespace Znalytic.Group5.Airline.BussinessLogicLayer
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
            bool result = _bookingList.Exists(temp => temp.customerID == customerID);
            return result;
        }
       
        /// <summary>
        /// This Method Represents AddFlightBooking
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddFlightBooking(FlightBooking customerID)
        {
            if (FlightBooking.customerID != null)
            {
                fbdl.AddFlightBooking(customerID);
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
        public List<FlightBooking> GetFlightBookings()
        {
            return fbdl.GetFlightBookings();
        }

    }

}



*/