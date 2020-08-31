using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    public interface ITicketCancellationBusinessLogicLayer
    {
        /// <summary>
        //Method to addticket cancellation details to the list
        /// </summary>
        /// <param name="tc"></param>

        void AddTicketCancellations(TicketCancellation bookingID);

        /// <summary>
        /// Method to get  added ticket cancellation details to the list
        /// </summary>
        /// <returns></returns>

        List<TicketCancellation> GetTicketCancellations();

        //Method to get Ticket Cancellations By Booking ID

        List<TicketCancellation> GetTicketCancellationsByBookingID(int bookingID);

        //method to get Ticket Cancellations By Customer ID
        List<TicketCancellation> GetTicketCancellationsByCustomerID(int customerID);

        //method to get Ticket Cancellations by cancellation ID
        List<TicketCancellation> GetTicketCancellationByCancellationID(int cancellationID);





    }
}