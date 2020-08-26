using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    public class TicketCancellationBusinessLogicLayer : ITicketCancellationBusinessLogicLayer;

        public TicketCancellationBusinessLogicLayer()
        {
            tcdal = new TicketCancellationDataAccessLayer();
        }

        public void AddbookingId(TicketCancellation bookingId)
        {
            if (TicketCancellation.bookingId != null)
            {
                _TicketcancellationDataAccessLayer.Add(bookingId);
            }
            else
            {
                throw new Exception("booking id can't be null");
            }
        }
        public void Adddate(TicketCancellation date)
        {
            if (TicketCancellation.date != null)
            {
                _TicketcancellationDataAccessLayer.Add(date);
            }
            else
            {
                throw new Exception("date can't be null");
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
