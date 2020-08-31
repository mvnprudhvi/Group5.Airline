//created by Madhumitha.....
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.DataAccessLayer
{
    interface ITicketCancellationDataAccessLayer
    {
        /// <summary>
        //Method to add ticket cancellation details to the list
        /// </summary>
        /// <param name="tc"></param>
        void AddTicketCancellations(TicketCancellation bookingId);

        //method to get ticket cancellations by cancellation Id

        List<TicketCancellation> GetTicketCancellationsByCancellationID(int cancellationID);

        //method Get TicketCancellations By Customer ID
        List<TicketCancellation> GetTicketCancellationsByCustomerID(int customerID);

        //method Get Ticket Cancellations By Booking ID
        List<TicketCancellation> GetTicketCancellationsByBookingID(int bookingID);

        //method to get ticket cancellations
        List<TicketCancellation> GetTicketCancellations();
    }
}