//created by Madhumitha.....
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Znalytics.Group5.Airline.Entities;
/// <summary>
/// represents dataAccessLayer of Ticketcancellation
/// </summary>


namespace Znalytics.Group5.DataAccessLayer
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    class TicketCancellationDataAccessLayer : ITicketCancellationDataAccessLayer
    {
        // creating list
        private static List<TicketCancellation> _TicketCancellation = new List<TicketCancellation>();

        //represents adding ticket cancellation
        public void AddTicketCancellation(TicketCancellation ticketCancellation)
        {
            _TicketCancellation = Add(ticketCancellation);
        }
        //Updation of  ticket cancellation
        public void UpdateTicketCancellation(TicketCancellation CustomerID)
        {
            //Get matching ticket cancellation based on CustomerId
            TicketCancellation tc = TicketCancellation.Find(temp => temp.CustomerID == customer.CustomerID);
            if (CustomerID != null)
            {
                TicketCancellation.CustomerID = TicketCancellation.CustomerID;
            }
        }
        public TicketCancellation GetTicketCancellationsByCustomerID(int CustomerID)
        {

        }
        public TicketCancellation GetTicketCancellationsByBookingID(int CustomerID)
        {

        }
        public TicketCancellation GetTicketCancellationsByCancellationID(int CustomerID)
        {

        }


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

}*/








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
