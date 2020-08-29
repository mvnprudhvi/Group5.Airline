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
    public class TicketCancellationBusinessLogicLayer : ITicketCancellationBusinessLogicLayer
    {
        private ITicketCancellationBusinessLogicLayer _tcdal = null;

        //Constructor for Business Logic Layer
        public TicketCancellationBusinessLogicLayer()
        {
            //Creating Object for ticket cancellation Data Access Layer
            _tcdal = new IFlightBookingDataAccessLayer();

        }

        /// <summary>
        /// This Method Represents AddTicketCancellation 
        /// </summary>
        /// <param name="bookingID"></param>

        public void AddTicketCancellation(TicketCancellation bookingID)
        {
            if (TicketCancellation.bookingID != null)
            {
                _tcdal.AddTicketCancellation(bookingID);
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
        public void UpdateTicketCancellations(TicketCancellation bookingID)
        {
            if (TicketCancellation.bookingID != null)
            {
                _tcdal.UpdateTicketCancellation(bookingID);
            }
            else
            {
                throw new Exception("booking id can't be null");
            }
        }
        //method to get ticket cancellation by ticket customer id
        public TicketCancellation GetTicketCancellationsByCustomerID(int _customerID)
        {
            return _tcdal.GetcustomerID();

        }

        public void DeleteTicketCancellation(TicketCancellation tc)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// This Method Represents GetbookingId 
    /// </summary>
    /// <returns>TicketCancellationDataAccessLayer</returns>
    public List<TicketCancellation> GetTicketCancellation()
    {
        return _tcdal.GetTicketCancellation();
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
