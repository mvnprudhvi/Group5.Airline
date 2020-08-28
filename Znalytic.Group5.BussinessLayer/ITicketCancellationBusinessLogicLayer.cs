using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.BussinessLogicLayer
{
    public interface ITicketCancellationBusinessLogicLayer
    {
        //represents add ticket cancellation
        public void AddTicketCancellation(TicketCancellation ticketCancellation);

        //represents update cancellation
        public void UpdateTicketCancellation(TicketCancellation ticketCancellation);


    }
}