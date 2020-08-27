using System;

namespace Znalytics.Group5.Airline.FlightModule.Entities
{
    class Flight
    {
        //Instance (or) non.staticfields
        private string _flightName { set; get; }
        private int _flightNumber { set; get; }
        private string _flightType { set; get; }
        private int _flightCapacity { set; get; }
        private int  _luggageWeightage { set; get; }

        //Constructor
        public Flight( string FlightName , int FlightNumber,string FlightType, int FlightCapacity, int LuggageWeightage)
        {
            
            _flightName = FlightName;
            _flightNumber = FlightNumber;
            _flightType = FlightType;
            _flightCapacity = FlightCapacity;
            _luggageWeightage = LuggageWeightage;      
        }

        public Flight()
        {
        }

        public string FlightName
        {
            set
            {
                if(FlightType.Length <= 10)
                {
                    _flightName = value;
                }
                else
                {
                    throw new Exception("FlightType should be less than 10");
                }
            }
            get
            {
                return   _flightType;
            }
        }
         public int FlightNumber
         {
            set
            {
                _flightNumber = value;
            }
            get
            {
                return _flightNumber;
            }
         }
        public string FlightType
        {
            set
            {
                _flightType = value;
            }
            get
            {
                return _flightType;
            }
        }

        public int  FlightCapacity
        {
            set
            {
                if( FlightCapacity  <= 250 )
                {
                    _flightCapacity = value;
                }
                else
                {
                    Console.WriteLine("Flight Capacity should not exceed 250");
                }
            }
            get
            {
                return _flightCapacity;
            }
        }

        public int LuggageWeightage
        {
            set
            {
                  if(LuggageWeightage <= 30)
                {
                    _luggageWeightage = value;
                }
                else
                {
                    Console.WriteLine(" Luggage Weightage should not exceed 30kgs ");
                }
               
            }
            get
            {
                return _luggageWeightage;
            }
        }
    }
}
