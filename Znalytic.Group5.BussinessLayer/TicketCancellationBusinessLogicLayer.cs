using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of ticket cancellation
    /// </summary>
    public class TicketCancellation
    {
        TicketCancellationDataAccessLayer _TicketCancellationDataAccessLayer;//Reference Variable Of Ticket cancellaation Data Access Layer

        //Constructor for Business Logic Layer
        public  void TicketCancellationBussinessLogicLayer()
        {
            _TicketCancellationDataAccessLayer = new TicketCancellationDataAccessLayer();//Creating Object for ticket cancellation Data Access Layer
        }

        /// <summary>
        /// This Method Represents AddBookingId 
        /// </summary>
        /// <param name="bookingID"></param>
        public void AddbookingId(TicketCancellation bookingId)
        {
            if (TicketCancellation.bookingId != null)
            {
                _TicketCancellationDataAccessLayer.AddbookingId(bookingId);
            }
            else
            {
                throw new Exception("bookingId can't be null");
            }
        }
        public void DeletebookingId(bookingId)
        {
            _TicketCancellationDataAccessLayer.DeletebookingId(bookingId);

        }

        /// <summary>
        /// This Method Represents Update ticket cancellation
        /// </summary>
        /// <param name="bookingid"></param>
        public void UpdatebookingId(TicketCancellation bookingId)
        {
            if (TicketCancellation.bookingId != null)
            {
                _TicketCancellationDataAccessLayer.UpdatebookingId(bookingId);
            }
        }

        /// <summary>
        /// This Method Represents GetbookingId 
        /// </summary>
        /// <returns>TicketCancellationDataAccessLayer</returns>
        public List<TicketCancellation> GetbookingId()
        {
            return _TicketCancellationDataAccessLayer.GetbookingId();
        }
        public List<TicketCancellation> Getdate()
        {
            return _TicketCancellationDataAccessLayer.Getdate();
        }
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
