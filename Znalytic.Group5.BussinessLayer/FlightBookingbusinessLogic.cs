
/*// created by reshma
// BusinessLogicLayer
// Module:FlightBooking

using System;
using Znalytics.Group5.Airline.FlightBookingModule.Entities;

using Znalytic.Group5.BussinessLogicLayer;
using System.Collections.Generic;
using Znalytics.Group5.DataAccessLayer;
using Znalytics.Group5.DataAccessLayer;
using Znalytic.Group5.Airline.DataAcessLayer;
using Znalytics.Group5.Airline.FlightBookingModule.Entities;
using Znalytics.Group5.Airline.FlightModule.BusinessLogicLayer;
using Znalytic.Group5.Airline.DataAcessLayer;

namespace Znalytic.Group5.Airline.FlightBookingModule.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of FlightBooking
    /// </summary>
    public class FlightBookingbusinessLogic : IFlightBookingbusinessLogic
    {
        //Created an object for DataAccessLayer and strore the object in reference variable
        FlightBookingDataAccessLayer fbdl = new FlightBookingDataAccessLayer();
        private readonly FlightBooking bookingId;

        public bool checkFlightBookingId(int bookingID)
        {
            List<FlightBooking> _bookingList = new List<FlightBooking>();
            // Flight flight = new Flight();
            bool result = _bookingList.Exists(temp => temp.BookingID == bookingID);
            return result;
        }

        /// <summary>
        /// This Method Represents AddFlightBooking
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddFlightBooking(FlightBooking bookingID)
        {
            if (FlightBooking.bookingID != 0)
            {
                fbdl.AddFlightBooking(bookingId);
            }
            else
            {
                throw new Exception("bookingId can't be null");
            }
        }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="schedule"></param>

        public void UpdateFlightBooking(FlightBooking booking)
        {

           
                //bookingID should not be null
                if (booking.BookingID != 0)

                //Calls the Update Method of FlightBooking of flightFlightBooking Data Layer
                {
                    fbdl.UpdateFlightBooking(booking);
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






