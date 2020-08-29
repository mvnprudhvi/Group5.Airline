/// <summary>
/// Created By Dinesh
/// Module Name is Flight Price
/// </summary>

using System;

namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// This Class Represents Price of Flight
    /// </summary>
    public class FlightPrice
    {
        //Private Fields
        private string _flightId;
        private string _flightScheduleId;
        private int _beforeDays;
        private double _priceForBusinessClassSeat;
        private double _priceForEconomyClassSeat;
        private double _weekendPriceHikePercentage;

        //Property For Flight Id
        public string FlightId
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.StartsWith("FID") && value.Length <= 8)
                    {
                        _flightId = value;
                    }
                    else
                    {
                        throw new FlightPriceException("Enter valid flightId");
                    }
                }
            }
            get
            {
                return _flightId;
            }
        }

        //Property For Flight Schedule Id
        public string FlightScheduleId
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.StartsWith("FSID") && value.Length <= 8)
                    {
                        _flightScheduleId = value;
                    }
                    else
                    {
                        throw new System.Exception("invalid flightScheduleid");
                    }
                }
            }
            get
            {
                return _flightScheduleId;
            }
        }


        //Property For Before Days
        public int BeforeDays
        {
            set
            {
                if (value <= 60)
                {
                    _beforeDays = value;
                }
                else
                {
                    throw new Exception("Please Enter Before Days Below 60 Days Only");
                }
            }
            get
            {
                return _beforeDays;
            }
        }
        //Property For Business class seat
        public double PriceForBusinessClassSeat
        {
            set
            {
                _priceForBusinessClassSeat = value;
            }
            get
            {
                return _priceForBusinessClassSeat;
            }
        }
        //Property For Price Economy Class Seat
        public double PriceForEconomyClassSeat
        {
            set
            {
                _priceForEconomyClassSeat = value;
            }
            get
            {
                return _priceForEconomyClassSeat;
            }
        }
        //Property For Weekend Hike Percentage
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