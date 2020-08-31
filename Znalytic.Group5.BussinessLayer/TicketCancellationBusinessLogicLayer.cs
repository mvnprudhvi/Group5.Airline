using System;
using System.Collections.Generic;
using Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.DataAccessLayer;
namespace Znalytic.Group5.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of ticket cancellation
    /// </summary>
    public class TicketCancellationBusinessLogicLayer : ITicketCancellationBusinessLogicLayer
    {

        //Created an object for DataAccessLayer and strore the object in reference variable
        TicketCancellationDataAccessLayer tcdal = new TicketCancellationDataAccessLayer();

        public bool checkCancellationID(int cancellationID)
        {
            List<TicketCancellation> _cancellationID = new List<TicketCancellation>();
       
            bool result = _cancellationID.Exists(temp => temp.CustomerID == customerID);
            return result;
        }


        /// <summary>
        /// This Method Represents AddTicketCancellation 
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddTicketCancellations(TicketCancellation bookingID)
        {
            if (TicketCancellation.bookingID != null)
            {
                tcdal.AddTicketCancellations(bookingID);
            }
            else
            {
                throw new Exception("bookingId can't be null");
            }
        }
        /// <summary>
        /// Method to GET the added cancellation id
        /// </summary>
        /// <returns></returns>
        public List<TicketCancellation> GetTicketCancellations()
        {
            return tcdal.GetTicketCancellations();
        }
        /// <summary>
        ///Method to GET ticket cancellation by booking id
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        public List<TicketCancellation> GetTicketCancellationsByBookingID(int bookingID)
        {
            return tcdal.GetTicketCancellationsByBookingID(bookingID);
        }
        /// <summary>
        /// Method to GET ticket cancellation by customer id
        /// </summary>
        /// <param name="customerid"></param>
        /// <returns></returns>
        public List<TicketCancellation> GetTicketCancellationsByCustomerID(int customerID)
        {
            return tcdal.GetTicketCancellationsByCustomerID(customerID);
        }
        /// <summary>
        /// Method to GET ticket cancellation by cancellation id
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public List<TicketCancellation> GetTicketCancellationByCancellationID(int cancellationID)
        {
            return tcdal.GetTicketCancellationsByCancellationID(cancellationID);
        }

        public void DeleteTicketCancellation(TicketCancellation tc)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicketCancellations(TicketCancellation tc)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// This Method Represents GetbookingId 
    /// </summary>
    /// <returns>TicketCancellationDataAccessLayer</returns>
    public List<TicketCancellation> GetTicketCancellations()
    {
        return tcdal.GetTicketCancellations();
    }
}






















/*using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;

namespace Znalytics.AirLine.BusinessLogicLayer
{
    public class CancellationBusinessLogicLayer : CancellationBusinessLogicLayer
    {
        private CancellationDataAccessLayer cdl = null;

        public CancellationBusinessLogicLayer()
        {
            cdal = new CancellationDataAccessLayer();
        }

        public void AddFlightName(FlightName FlightName)
        {
            if (FlightName.FlightName != null)

                cdal.AddFlightName(FlightName);
        }
    }
}*/










/*//using system.Znalytic.Group5.BussinessLayer
    public  class FlightBussinessLayer
    {
        public void AddFlight(Flight fn)
    {
        if(Flight.FlightName<=30)
        {
            FlightBussinessLayer fdl = new FlightBussinessLayer()
        }
    }

    }
}
