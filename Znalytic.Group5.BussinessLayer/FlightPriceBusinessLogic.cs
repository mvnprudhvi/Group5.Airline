/*/// <summary>
/// Created By Dinesh
/// Module Name is FlightPrice
/// </summary>

//This Represents Importing Statements
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;
using System.Collections.Generic;

/// <summary>
/// Created a namespace for Business Logic Layer of Airline Reservation System
/// </summary>
namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
    /// <summary>
    /// This Class Represents Business Logic Layer Of Price
    /// </summary>
    public class FlightPriceBusinessLogic : IFlightPriceBusinessLogic
    {
        //Creating Reference Variable Of FlightPrice Data Access Layer
        private IFlightPriceDataAccessLayer _flightPriceDataAccessLayer;

        /// <summary>
        /// Constructor For FligthPrice Business Logic Layer
        /// </summary>
        public FlightPriceBusinessLogic()
        {
            //Creating Object of FlightPrice Data Access Layer
            _flightPriceDataAccessLayer = new FlightPriceDataAccessLayer();
        }

        /// <summary>
        /// This Method Represents AddPrice to Add the FlightPrice Details into List
        /// </summary>
        /// <param name="price"></param>
        public void AddFlightPrice(FlightPrice price)
        {
            //calling AddFlightPrice Method to Data Access Layer Through Reference Variable of FlightPriceDataAccessLayer
            _flightPriceDataAccessLayer.AddFlightPrice(price);
        }

        /// <summary>
        /// This Method Represents DeletePrice to Delete the FlightPrice Details into List
        /// </summary>
        /// <param name="price"></param>
        public void DeleteFlightPrice(FlightPrice price)
        {
            //calling DeleteFlightPrice Method to Data Access Layer Through Reference Variable of FlightPriceDataAccessLayer
            _flightPriceDataAccessLayer.DeleteFlightPrice(price);
        }

        /// <summary>
        /// This Method Represents UpdatePrice to Update the FlightPrice Details into List
        /// </summary>
        /// <param name="price"></param>
        public void UpdateFlightPrice(FlightPrice price)
        {
            //calling UpdateFlightPrice Method to Data Access Layer Through Reference Variable of FlightPriceDataAccessLayer
            _flightPriceDataAccessLayer.UpdateFlightPrice(price);
        }

        /// <summary>
        /// This Method Represents to Update the Weekend Hike Percentage Based on Individual ScheduleId 
        /// </summary>
        /// <param name="price"></param>
        public void UpdateWeekendPriceHikePercentageByScheduleId(FlightPrice price)
        {
            if (price.WeekendPriceHikePercentage > 0 && price.WeekendPriceHikePercentage <= 100)
            {
                //calling UpdateWeekendPriceHikePercentageByScheduleId Method to Data Access Layer Through Reference Variable of FlightPriceDataAccessLayer
                _flightPriceDataAccessLayer.UpdateWeekendPriceHikePercentageByScheduleId(price);
            }
            else
            {
                throw new FlightPriceException("Please Enter Percentage Between 1 to 100");
            }
        }

        /// <summary>
        /// This Method Represents to Update the Weekend Hike Percentage For All ScheduleId's
        /// </summary>
        /// <param name="weekendPriceHikePercentage"></param>
        public void UpdateWeekendPriceHikePercentageForAllSchedules(double weekendPriceHikePercentage)
        {
            //calling UpdateWeekendPriceHikePercentageForAllSchedules Method to Data Access Layer Through Reference Variable of FlightPriceDataAccessLayer
            _flightPriceDataAccessLayer.UpdateWeekendPriceHikePercentageForAllSchedules(weekendPriceHikePercentage);
        }


        /// <summary>
        /// This Method Represents to Get the FlightPrices Based on Before Days
        /// </summary>
        /// <returns>_priceDataAccessLayer</returns>
        public List<FlightPrice> GetFlightPricesByBeforeDays(int beforedays)
        {
            //Creating Reference Variable of List<FlightPrice>
            List<FlightPrice> prs;

            //calling GetFlightPricesByBeforeDays Method to Data Access Layer through Reference Variable of List<FlightPrice>
            prs = _flightPriceDataAccessLayer.GetFlightPricesByBeforeDays();

            //Creating newlist in List<FlightPrice>
            List<FlightPrice> newlist = new List<FlightPrice>();

            //This Represents Difference of Before Days and Maxdays given 60 
            int diff = 60 - beforedays;

            if (beforedays > 0 && beforedays <= 60)
            {
                //foreach is to Calulating Before Days Prices and 
                //it also Calculating Weekend Hike Percentage When Admin is Updated
                foreach (FlightPrice pri in prs)
                {
                    //Creating Object of FlightPrice
                    FlightPrice p = new FlightPrice();

                    //Storing ScheduleId in Object 
                    p.FlightScheduleId = pri.FlightScheduleId;

                    //Storing Business Class Seat Price and also Calculating before days Price of Business Class Seat and WeekendHike Percentage by Using Diff 
                    p.PriceForBusinessClassSeat = pri.PriceForBusinessClassSeat * (1 + (pri.WeekendPriceHikePercentage / 100)) + 1000 * diff;

                    //Storing Economy Class Seat Price and also Calculating before days Price of Economy Class Seat and WeekendHike Percentage by Using Diff 
                    p.PriceForEconomyClassSeat = pri.PriceForEconomyClassSeat * (1 + (pri.WeekendPriceHikePercentage / 100)) + 500 * diff;

                    //Storing Weekend Hike Perecentage in Object
                    p.WeekendPriceHikePercentage = pri.WeekendPriceHikePercentage;

                    //Adding All Above Details in newlist of List<FlightPrice>
                    newlist.Add(p);
                }
                //It Represents Returning all Details into newlist of List<<FlightPrice>
                return newlist;
            }
            else
            {
                throw new FlightPriceException("Please Enter Before Days Between 1 to 60");
            }
        }
    }
}*/