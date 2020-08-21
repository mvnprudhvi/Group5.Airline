// created by Reshma//
/// <summary>
/// Represents Flightsearching
/// </summary>
/// 

namespace Znalytics.Group5.Airline.Flightsearching.entities

{

    public class Flightsearching

    {

        //auto-impl properties
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        //public Employee(int EmployeeID, string EmployeeName)
        //{
        //    this.EmployeeID = EmployeeID;
        //    this.EmployeeName = EmployeeName;
        //}
    }
}








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
