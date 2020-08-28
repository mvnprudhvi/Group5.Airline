using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of ticket cancellation
    /// </summary>
    public class TicketCancellationBusinessLogicLayer : ITicketCancellationBusinessLogicLayer
    {
        private ITicketCancellationDataAccessLayer tcdal = null;
        //Constructor for Business Logic Layer
        public TicketCancellationBusinessLogicLayer()
        {
            tcdal = new TicketCancellationDataAccessLayer();//Creating Object for ticket cancellation Data Access Layer
        }

        /// <summary>
        /// This Method Represents AddTicketCancellation 
        /// </summary>
        /// <param name="bookingID"></param>
        public void AddTicketCancellation(TicketCancellation ticketCancellation)
        {
            if (TicketCancellation.BookingID != null)
            {
                _tcdal.AddTicketCancellation(BookingID);
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
        public void UpdateTicketCancellation(TicketCancellation ticketCancellation)
        {
            if (TicketCancellation.BookingID != null)
            {
                _TicketCancellationDataAccessLayer.UpdateTiketCancellation(bookingId);
                else
                {
                    throw new Exception("bookingId can't be null");
                }
            }
        }
    }

    /// <summary>
    /// This Method Represents GetbookingId 
    /// </summary>
    /// <returns>TicketCancellationDataAccessLayer</returns>
    public List<TicketCancellation> GetTicketCancellation()
    {
        return TicketCancellationDataAccessLayer.GetTicketCancellation();
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
