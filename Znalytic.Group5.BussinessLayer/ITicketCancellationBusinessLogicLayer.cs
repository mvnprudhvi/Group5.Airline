using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    public interface ITicketCancellationBusinessLogicLayer
    {
        //this method represents add ticket cancellation
        void AddTicketCancellation(TicketCancellation ticketCancellation);

        //this method represents update cancellation
        void UpdateTicketCancellation(TicketCancellation ticketCancellation);

        //this method represents get ticket cancellation by customer id
        TicketCancellation GetTicketCancellationsByCustomerID(int _customerID);
        TicketCancellation GetTicketCancellationsByCancellationID(int cancellationID);
    }
}