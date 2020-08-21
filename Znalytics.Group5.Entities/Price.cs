//Created By Dinesh
namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// This Class Represents Price of Flight
    /// </summary>
    public class Price
    {
        public static object price;

        //auto-impl properties
        public int FlightID { get; set; }
        public string FlightName { get; set; }
        public double FlightPrice { get; set; }

        //Constructor
        public Price(int FlightID, string FlightName, double FlightPrice)
        {
            this.FlightID = FlightID;
            this.FlightName = FlightName;
            this.FlightPrice = FlightPrice;
        }

        public Price()
        {
        }
    }
}

