// created by Reshma//
/// <summary>
/// Represents Flightsearching
/// </summary>
   namespace Znaltyics.Group5.Airline.Flightsearching.Entities
{
   
        public class Flightsearching
        {
            //auto-implimented properties
            public int FlightID { get; set; }
            public string FlightName { get; set; }

        //public Flight(int FlightID, string FlightName)
        //{
        //    this.FlightID = FlightID;
        //    this.FlightName = FlightName;
        //}
    }
    
  // public class FlightSearching
    {
        //private fields
        private string _FlightName;
        private int _NumberOfFlights;
        private System.DateTime _FlightTime;
        private System.DateTime _FlightDate;

        /// <summary>
        /// Constructor that initializes details of FlightSearching
        /// </summary>
        /// <param name="FlightName">Represents flight number</param>
        ///     <param name=" NumberOfFlights">Represents no flight number</param>
        /// <param name="FlightTime">represents time of flight</param>
        /// <param name="FlightDate">represents date of flight</param>


        public FlightSearching(string FlightName, int NumberOfFlights, int FlightTime, int FlightDate)
        {
            //_FlightName = flightName;
            //_NumberOfFlights=numberoOfFlights
            //_FlightDate = flightdate;
            //_FlightTime =flighttime;



            _FlightName = FlightName; //set method will be called
            _NumberOfFlights = NumberOfFlights;
            _FlightDate = FlightDate; //set method will be called
            _FlightTime = FlightTime;

        }
    //

        /// <summary>
        /// Parameterless constructor
        /// </summary>
        public FlightSearching()
        {
            //not initializing
        }



        /// <summary>
        /// Represents name of the AirLine
        /// </summary>
        public string FlightName
        {
            set
            {
                //Name should be less than 30 string characters
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

        /// <summary>
        /// date of flight
        /// </summary>
        /// 


        public System.DateTime date
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
        //
        public int Time
        {
            set
            {

                if ()
                {
                    _Time = value;
                }
            }

            get
            {
                return _Time;
            }
        }
    }
    //
