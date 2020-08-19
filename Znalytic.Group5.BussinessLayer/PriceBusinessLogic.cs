using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.BusinessLogicLayer
{
     public class PriceBusinessLogic
     {
        private PriceDataAccessLayer priceDataAccessLayer=new PriceDataAccessLayer();
        public void AddPrice(double price)
        {
            priceDataAccessLayer.AddPrice(price);
        }
    }
}