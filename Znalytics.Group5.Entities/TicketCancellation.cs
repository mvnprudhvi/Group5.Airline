//created by Madhumitha
//Entities
//module:Ticketcancellation
using System;

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
                //id of the customerId should be 5 digits 
                if (value <= 5)
                {
                    _flightID = value;
                }
                else
                {
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
                //id of the customerId should be 5 digits 
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
                //id of the customerId should be 5 digits 
                if (value <= 5)
                {
                    _cancellationID = value;
                }
                else
                {
                    //throws exception that booking id shuold be 5 digits only
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










        /*public int price
       {
           set
            {

                _price = value;
            }
            get { return _price; }
        }

        /*public string date
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
    }
}


       /* public string arrivalTiming
        {
            set
            {
                _arrivalTiming = value;
            }
            get { return _arrivalTiming; }
        }

    }*/



        /*namespace Znalytics.Airline.CancellationModule.Entitie
            public class Airline
        {
            private int _FlightNumber;
            private string _View;
            private int _Time;
            private int _Date;
            private string _Cancel;
            public void SetFlightNumber(int value)
            {
                _FlightNumber = value;
            }
            public int FlightNumber()
            {
                return _FlightNumber;
            }
            public void SetView(string value)
            {
                _View = value;

            }
            public string GetView()
            {
                return _View;
            }
            public void SetTime(int value)
            {
                _Time = value;

            }
            public int GetTime()
            {
                return _Time;
            }
            public void SetDate(int value)
            {
                _Date = value;

            }
            public int GetDate()
            {
                return _Date;
            }
            public void SetCancel(string value)
            {
                _Cancel = value;

            }
            public string GetCancel()
            {
                return _Cancel;
            }

        }

        /*{
            private string _FlightName;
            private System.DateTime _Date;
            private System.DateTime _Time;
            private bool _Cancel;


            public string FlightName
            {
                set
                {
                    if (value.Length <= 30)
                    {
                        _FlightName = value;
                    }
                }
                get
                {
                    return _FlightName;
                }
            }
            public string Cancel
            {
                set
                {
                    if (value.Length <= 30)
                    {
                        _Cancel = value;
                    }
                }
                get
                {
                    return _Cancel;
                }
            }



            /*public System.DateTime _Date;
                    {
                        set
                        {
                            _Date = value;
                        }
                        get
                        {
                            return _Date;
                        }
                    }
            public System.DateTime _Date;
                    {
                        set
                        {
                            _Date = value;
                        }
                        get
                        {
                            return _Date;
                        }
                    }


            public override string ToString()
            {
                return base.ToString() + "FlightName: " + FlightName + ", Cancel: " + Cancel;
            }

            public override int GetHashCode()
            {
                return 1000;
            }*/






        /* public class Flight
        {
        private string _FlightName;
        private System.DateTime _Date;
        private System.DateTime _Time;
        private string _Cancel;

        public void SetFlightName(string FlightName)
        {
         this._FlightName = FlightName;
        }
        public string GetFlightName()
        {
         return this._FlightName;
        }
        public void SetDate(System.DateTime Date)
        {
         this._Date = Date;
        }
        public string GetDate()
        {
         return this._FlightName;
        }
        public void SetCancel(string Cancel)
        {
         this._Cancel = Cancel;
        }
        public string GetCancel()
        {
         return this._Cancel;
        }
        }

        /*public void SetTime(System.DateTime Time)
        {
        this._Time = Time;
        }
        public System.DateTime GetDate()
        {
        return this._Time;
        }
        }





    }
}*/
