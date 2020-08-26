//created by Madhumitha
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group5.Airline.Entities;
/// <summary>
/// represents dataAccessLayer of Ticketcancellation
/// </summary>


namespace Znalytics.Group5.DataAccessLayer
{
    class TicketCancellationDataAccessLayer
    { 

            // create list
            private static List<TicketCancellation> _flights = new List<TicketCancellation>();

            //Add
            public void (flightName flight)
            {
                _flights.Add(flightName);
            }

            //Get a
            public List<FlightName> GetFlightNames()
            {
                return _flightName;
            }



            /// <summary>
            /// Delete Method with 2 parameters
            /// </summary>
            /// <param name="flightId"></param>
            /// <param name="flightName"></param>
            public void DeleteFlightNameByflightId(int flightId, string flightName)
            {
                _flights.RemoveAll(temp => temp.flightId == flightId && temp.flightName == flightName);
            }
        }








    /*using System.Collections.Generic;
    using Znalytics.Group5.AirLine.CancellationModule.Entities;

    namespace Znalytics.Group5.AirLine.CancellationDataAccessLayer
    {
        public class FlightCancellationDataAccessLayer : CancellationDataAccessLayer
        {
            //create list
            List<FlightName> FlightName = new List<FlightName>();

            public void AddFlightName(FlightName FlightName)
            {
                ////flight generating 

                //flight.Add(flight);

                //not done
            }
        }
    }*/
