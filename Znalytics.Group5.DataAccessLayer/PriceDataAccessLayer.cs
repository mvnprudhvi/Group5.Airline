using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public class PriceDataAccessLayer
    {
        //create list
        List<Price> prices = new List<Price>();
        public void AddPrice(double price)
        {
            Price p = new Price();
            p.AirlinePrice = price;

            prices.Add(p);
        }
        
    }
}
