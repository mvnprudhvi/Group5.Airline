//created by Madhumitha.....
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group5.Airline.Entities;
/// <summary>
/// represents dataAccessLayer of Ticketcancellation
/// </summary>


namespace Znalytics.Group5.DataAccessLayer
{
    class TicketCancellationDataAccessLayer
    {

        // create list
        private static List<TicketCancellation> _flights = new List<TicketCancellation>();

        //represents adding booking id
        public void AddbookingId(TicketCancellation bookingId)
        {
            _flights.Add(bookingId);
        }

        //represents Get  bookingid
        public List<TicketCancellation> GetbookingId()
        {
            return _flights;
        }


        //add date
        public void Adddate(TicketCancellation date)
        {
            _flights.Add(date);
        }

        //Get  date
        public List<TicketCancellation> Getdate()
        {
            return _flights;
        }
        //update date
        public void updatedate(TicketCancellation date)
        {
            _flights.Add(date);
        }
    }








    /*using System.Collections.Generic;
    using Znalytics.Group5.AirLine.CancellationModule.Entities;

    namespace Znalytics.Group5.AirLine.CancellationDataAccessLayer
    {
        public class FlightCancellationDataAccessLayer : CancellationDataAccessLayer
        {
            //create list
            List<FlightName> FlightName = new List<FlightName>();

            public void AddFlightName(FlightName FlightName)
            {
                ////flight generating 

                //flight.Add(flight);

                //not done
            }
        }
    }*/
