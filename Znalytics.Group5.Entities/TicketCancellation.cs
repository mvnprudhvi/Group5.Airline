//created by Madhumitha........
//Entities...
//module:Ticketcancellation
using System;
//name space that represents ticket cancellation...
namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// This Class Represents cancellation of ticket
    /// </summary>
    public class TicketCancellation
    {
        //represents Private Fields...
        private int _customerID;
        private int _bookingID;
        private int _flightID;
        private int _seatNumber;
        private DateTime _date;
        private int _cancellationID;

        public TicketCancellation()
        {

        }

        /// <summary>
        /// Constructor that initializes details of ticketcancellation
        /// </summary>
        public TicketCancellation(int customerId, int bookingId, int flightId, int seatNumber, DateTime date, int cancellationId)
        {
            /// <param name="customerId">Represents id of the store</param>
            /// <param name="bookingId">Represents name of the store</param>
            /// <param name="seatNumber">Represents location of the store</param>
            /// <param name="date">Represents phone number of the store</param>

            _customerID = customerId;
            _bookingID = bookingId;
            _flightID = flightId;
            _seatNumber = seatNumber;
            _date = date;
            _cancellationID = cancellationId;
        }

        public static object bookingID { get; set; }

        public int CustomerID
        {
            set
            {
                //id of the customerId should be 5 digits 
                if (value <= 5)
                {
                    _customerID = value;
                }
                else
                {
                    throw new Exception("customer id should not exceed 5 digits");
                }
            }
            get
            {
                return _customerID;
            }
        }
        public int FlightID
        {
            set
            {
                //id of the flight Id should be 5 digits 
                if (value <= 5)
                {
                    _flightID = value;
                }
                else
                {
                    //id of the flight Id should not exceed 5 digits
                    throw new Exception("flight id should not exceed 5 digits");
                }
            }
            get
            {
                return _flightID;
            }
        }
        public int BookingID
        {
            set
            {
                //id of the booking id should be 5 digits 
                if (value <= 5)
                {
                    BookingID = value;
                }
                else
                {
                    //throws exception that booking id shuold be 5 digits only
                    throw new Exception("booking id should not exceed 5 digits");
                }
            }
            get
            {
                return BookingID;
            }
        }
        public int SeatNumber
        {
            set
            {
                //id of the seatNumber should be 5 digits 
                if (value <= 5)
                {
                    _seatNumber = value;
                }
                else
                {
                    //throws exception that seatNumber shuold be 5 digits only
                    throw new Exception("seatNumber should not exceed 5 digits");
                }
            }
            get
            {
                return _seatNumber;
            }
        }
        public DateTime Date

        {
            set
            {
                _date = value;
            }
            get
            {
                return _date;
            }
        }
        public int CancellationID
        {
            set
            {
                //id of the cancellation Id should be 5 digits 
                if (value <= 5)
                {
                    _cancellationID = value;
                }
                else
                {
                    //throws exception that cancellation id shuold be 5 digits only
                    throw new Exception("booking id should not exceed 5 digits");
                }
            }
            get
            {
                return _cancellationID;
            }
        }
    }
}