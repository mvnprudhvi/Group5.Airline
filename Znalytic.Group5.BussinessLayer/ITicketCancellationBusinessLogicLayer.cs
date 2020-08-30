using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    public interface ITicketCancellationBusinessLogicLayer
    {
        //this method represents add ticket cancellation
        public void AddTicketCancellation(TicketCancellation ticketCancellation);

        //this method represents update cancellation
        public void UpdateTicketCancellation(TicketCancellation ticketCancellation);

        //this method represents get ticket cancellation by customer id
        public TicketCancellation GetTicketCancellationsByCustomerID(int _customerID);
        public TicketCancellation GetTicketCancellationsByCancellationID(int cancellationID);
    }
}