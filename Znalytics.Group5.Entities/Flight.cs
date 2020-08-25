using System;

namespace Znalytics.Group5.Entities
{
    class Flight
    {
        private string _flightName { set; get; }
        private string _flightNumber { set; get; }
        private string _flightCapacity { set; get; }
        private string  _luggageWeightage { set; get; }


        public Flight( string FlightName , string FlightNumber , string FlightCapacity, string LuggageWeightage)
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
         public string FlightNumber
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

        public string FlightCapacity
        {
            set
            {
                if( FlightCapacity.Length <= 250 )
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

        public string LuggageWeightage
        {
            set
            {
                  if(LuggageWeightage.Length <= 30)
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
