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


        //Using Properties For all Fields
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
        }*/
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