using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.DataAccessLayer
{
    interface IFlightPriceDataAccessLayer
    {
       void AddFlightPrice();
       void DeleteFlightPrice();
       void UpdateFlightPrice();
        void GetFlightPrices();
    }
}
