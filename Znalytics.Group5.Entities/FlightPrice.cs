/// <summary>
/// Created By Dinesh
/// Module Name is Flight Price
/// </summary>

namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// This Class Represents Price of Flight
    /// </summary>
    public class FlightPrice
    {
        //Private Fields
        private int _beforeDays;
        private double _priceForBusinessClassSeat;
        private double _priceForEconomyClassSeat;
        private double _weekendPriceHikePercentage;

        //Property For Before Days
        public int BeforeDays
        {
            set
            {
               
                _beforeDays = value;
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