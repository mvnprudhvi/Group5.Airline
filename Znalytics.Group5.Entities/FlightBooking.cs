using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.Entities
{

        public class FlightBooking
        {
            string _flightName { set; get; }
            int _flightId { set; get; }
            string _passengerName { set; get; }
            int _seatNumber { set; get; }


            public FlightBooking(string flightName, int flightId, string spassengerName, int seatNumber)
            {
                _flightName = flightName;
                _flightId = flightId;
                _passengerName = passengerName;
                _seatNumber = seatNumber;
            }
            public string flightName
            {
                set
                {
                    _flightName = value;
                }
                get
                {
                    return _flightName;
                }
            }

            public int flightId
            {
                set
                {
                    _flightId = value;
                }
                get
                {
                    return _flightId;
                }
            }

            public string passengerName
            {
                set
                {
                    _passengerName = value;
                }
                get
                {
                    return _passengerName;
                }
            }

            public int SeatNumber
            {
                set
                {
                    _seatNumber = value;
                }
                get
                {
                    return _seatNumber;
                }
            }

        }
    }



