/// <summary>
/// Created By Dinesh
/// Module Name is FlightPrice
/// </summary>

//This Represents Importing Statements
/*using System.Text.RegularExpressions;


/// <summary>
/// Created a namespace for Entity Layer of Airline Reservation System
/// </summary>
namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// This Class Represents Price of Flight
    /// </summary>
    public class FlightPrice
    {
        //Private Fields for Flight Price
        private string _flightScheduleId;
        private double _priceForBusinessClassSeat;
        private double _priceForEconomyClassSeat;
        private double _weekendPriceHikePercentage;


        /// <summary>
        ///Property For Flight ScheduleId 
        /// </summary>
        public string FlightScheduleId
        {
            set
            {
                //This Represents Regular Expression for AlphaNumeric values
                Regex r = new Regex("[A-Z0-9]$");

                //WareHouseId should not be null or empty 
                //Mandatory to Starts With "FSID" at Beginning
                if (!string.IsNullOrEmpty(value) && value.StartsWith("FSID") && r.IsMatch(value) && value.Length <= 8)
                {
                    _flightScheduleId = value;
                }
                else
                {
                    throw new FlightPriceException("Enter Valid ScheduleId it Should not Contain Spaces and length should be less than or equal to 8");
                }
            }
            get
            {
                return _flightScheduleId;
            }
        }


        /// <summary>
        /// Property For price Business class seat
        /// </summary>
        public double PriceForBusinessClassSeat
        {
            set
            {
                //Value Should be Greater Than Zero
                if (value > 0)
                {
                    _priceForBusinessClassSeat = value;
                }
                else
                {
                    throw new FlightPriceException("Please Enter Positive Values");
                }
            }
            get
            {
                return _priceForBusinessClassSeat;
            }
        }


        /// <summary>
        /// Property For price Economy class seat
        /// </summary>
        public double PriceForEconomyClassSeat
        {
            set
            {
                //Value Should be Greater Than Zero
                if (value > 0)
                {
                    _priceForEconomyClassSeat = value;
                }
                else
                {
                    throw new FlightPriceException("Please Enter Positive Values");
                }
            }
            get
            {
                return _priceForEconomyClassSeat;
            }
        }


        /// <summary>
        /// Property For Weekend price Hike Percentage
        /// </summary>
        public double WeekendPriceHikePercentage
        {
            set
            {
                _weekendPriceHikePercentage = value;
            }
            get
            {
                return _weekendPriceHikePercentage;
            }
        }

    }
}