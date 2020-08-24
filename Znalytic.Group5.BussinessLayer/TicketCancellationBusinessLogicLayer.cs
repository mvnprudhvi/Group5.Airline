using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    class TicketCancellationBusinessLogicLayer : _ITicketCancellationBusinessLogicLayer;
            {
        private TicketCancellationDataAccessLayer _tdal = null;

        public TicketCancellationBusinessLogicLayer()
        {
            tdal = new CustomerDataAccessLayer();
        }

        public void AddBookingId(TicketCancellation Ticket)
        {
            if (bookingID.BookingId != null)
            {
                tdal.AddbookingId(bookingId);
            }
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
