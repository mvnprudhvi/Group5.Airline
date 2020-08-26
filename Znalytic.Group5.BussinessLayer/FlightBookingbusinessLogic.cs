
// 



using System;



using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;

namespace Znalytic.Group5.Airline.FlightBooking.BussinessLogicLayer
{
   
        public class FlightSearchingbusinessLogicLayer : _FlightSearchingbusinessLogicLayer();
            {
            private FlightSearchingDataAcessLayer _fsdal = null;

            public FlightSearchingbusinessLogicLayer()
            {
                _fsdal = new FlightSearchingDataAcessLayer();
            }

            public void Add(FlightSearching bookingId)
            {
                if (FlightSearching.bookingId != null)
                {
                    _FlightSearchingDataAcessLayer.Add(bookingId);
                }
                else
                {
                    throw new Exception("booking id can't be null");
                }
            }




        }
    }
