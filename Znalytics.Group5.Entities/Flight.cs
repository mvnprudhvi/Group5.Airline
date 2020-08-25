using System;

namespace Znalytics.Group5.Entities
{
    class Flight
    {
        private string _flightName { set; get; }
        private int _flightNumber { set; get; }
        private int _flightCapacity { set; get; }
        private int  _luggageWeightage { set; get; }


        public Flight( string FlightName , int FlightNumber , int FlightCapacity, int LuggageWeightage)
        {
            _flightName = FlightName;
            _flightNumber = FlightNumber;
            _flightCapacity = FlightCapacity;
            _luggageWeightage = LuggageWeightage;      
        }

        public string FlightName
        {
            set
            {
                _flightName = value; // set the value
            }
            get
            {
                return _flightName; // get the value
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
