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
        //Using Automatic Implemented properties
        public double Price{ get; set; }

        //Using Parameterised Constructor
        public FlightPrice(double Price)
        {
            this.Price = Price;
        }

        //Default Constructor Which is Parameter Less
        public FlightPrice()
        {
        }
    }
}
