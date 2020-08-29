using System;

namespace Znalytics.Group5.Airline.FlightModule.Entities
{
    public class Flight
    {
        //Instance (or) non.staticfields
        private string _flightName { set; get; }
        private string _flightId { set; get; }
        private string _flightType { set; get; }
        private string _luggageWeightage { set; get; }
        private string _noOfEconomySeats { set; get; }
        private string _noOfBusinessSeats { set; get; }


        //Constructor
        public Flight(string FlightName, string FlightId, string FlightType, string luggageWeightage, string NoOfEconomySeats, string NoOfBusinessSeats)
        {

            _flightName = flightName;
            _flightId = flightId;
            _flightType = flightType;
            _luggageWeightage = luggageWeightage;
            _noOfEconomySeats = noOfEconomySeats;
            _noOfBusinessSeats = noOfBusinessSeats;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Flight()
        {

        }


        /// <summary>
        /// propery for  flightName
        /// </summary>
        public string flightName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 10)
                    {
                        _flightName = value;
                    }


                    else
                    {
                        throw new Exception("Invalid flightName name");
                    }
                }
            }
            get
            {
                return _flightName;
            }
        }

        /// <summary>
        /// property for flightId
        /// </summary>
        public string flightId
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.StartsWith("FID") && value.Length <= 4)
                    {
                        _flightId = value;
                    }


                    else
                    {
                        throw new Exception("Enter valid flightId");
                    }
                }
            }
            get
            {
                return _flightId;
            }
        }

        /// <summary>
        /// proprty for flightType
        /// </summary>
        public string flightType
        {
            set
            {
                bool atFound = value.Contains("@");
                bool commaFound = value.Contains(",");
                if (!atFound && !commaFound && value.Length <= 10)
                {
                    _flightType = value;
                }
                else

                {
                    throw new Exception("Invalid flightType name");
                }

            }
            get
            {
                return _flightType;
            }
        }

        /// <summary>
        /// property for weight of a luggage
        /// </summary>
        public string luggageWeightage
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.EndsWith("kgs") && value.Length <= 4)
                    {
                        _luggageWeightage = value;
                    }
                }
                else
                {
                    throw new Exception(" weight should be only  in kgs");
                }
            }

            get
            {
                return _luggageWeightage;
            }
        }

        /// <summary>
        /// property for noof EconomySeats
        /// </summary>
        public string noOfEconomySeats
        {
            set
            {

                bool characterFound = value.Contains(" ");
                bool atFound = value.Contains("@");
                bool commaFound = value.Contains(",");
                bool specialcharacterFound = value.Contains(":,_,+");
                if (!characterFound && !atFound && !commaFound && !specialcharacterFound && value.Length <= 280)
                {
                    _noOfEconomySeats = value;
                }


                else
                {
                    throw new Exception("Enter valid flightId");
                }
            }
            get
            {
                return _noOfEconomySeats;
            }
        }

        /// <summary>
        /// property for noOfBusinesssSeats
        /// </summary>

        public string noOfBusinessSeats
        {
            set
            {

                bool characterFound = value.Contains(" ");
                bool atFound = value.Contains("@");
                bool commaFound = value.Contains(",");
                bool specialcharacterFound = value.Contains(":,_,+");
                if (!characterFound && !atFound && !commaFound && !specialcharacterFound && value.Length <= 30)
                {
                    _noOfBusinessSeats = value;
                }


                else
                {
                    throw new Exception("Enter valid flightId");
                }
            }
            get
            {
                return _noOfBusinessSeats;
            }
        }




    }
}

