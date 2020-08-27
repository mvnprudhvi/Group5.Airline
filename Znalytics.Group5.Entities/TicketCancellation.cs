//created by Madhumitha
//Entities
namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// This Class Represents cancellation of ticket
    /// </summary>

    public class TicketCancellation

    {
        //Private Fields
        //represeents auto implemented properties
        private int _bookingId { set; get; }
        //private string _flightName { set; get; }

        private int _seatNumber { set; get; }

        //private int _price { set; get; }
        private string _date { set; get; }
        // private string _arrivalTiming { set; get; }

        //constructor
        public TicketCancellation(int bookingId, int seatNumber,  string date)
        {
            // _flightName = flightName;
            //_flightId = flightId;
            _bookingId = bookingId;
            _seatNumber = seatNumber;
            //_price = price;
            _date = date;
            // _arrivalTiming = arrivalTiming;
        }

        //properties
        /*public string flightName
        {
            set
            //set the value
            {

                _flightName = value;
            }
            get { return _flightName; } // get the value
        }


        public int flightId
        {
            set
            {

                _flightId = value;
            }
            get { return _flightId; }
        }*/

        public int bookingid
        {
            set
            {

                _bookingId = value;
            }
            get { return _bookingId; }
        }


        public int seatNumber
        {
            set
            {

                _seatNumber = value;
            }
            get { return _seatNumber; }
        }
        /*public int price
       {
           set
            {

                _price = value;
            }
            get { return _price; }
        }*/

        public string date
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
