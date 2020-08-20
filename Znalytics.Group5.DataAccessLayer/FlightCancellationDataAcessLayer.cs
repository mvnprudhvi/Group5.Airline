using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    public class FlightCancellationDataAccessLayer
    {
        //private fields
        private static List<FlightCancellationDataAccessLayer> _flightcancellations;

        //constructor
        static FlightCancellationDataAccessLayer()
        {
            _FlightCancellation = new List<FlightCancellation>()
            {
                new FlightCancellationDataAccessLayer(){ FlightID = 12345, FlightName = "Indigo" },
                new FlightCancellationDataAccessLayer(){ FlightID = 56789, FlightName = "BritishAirways" }
            };
        }

    }
        public void Add(FlightName FlightName)
        {
            _FlightName.Add(flightName);
        }

        //Get all flights
        public List<FlightCancellation> GetFlightCancellation()
        {
            return _FlightName;
        }

        //Update
        public void UpdateFlightCancellation(flightcancellation flightcancellation)
        {
            //Get matching flightname based on flightid
            FlightCancellationDataAccessLayer fli = _flightid.Find(temp => temp.FlightID == FlightCancellationDataAccessLayer.EmployeeID);
            if (fli != null)
            {
                fli.flightcancellation = flightcancellation.FlightName;
            }
        }
    }



































/*using System.Collections.Generic;
using Znalytics.Group5.AirLine.CancellationModule.Entities;

namespace Znalytics.Group5.AirLine.CancellationDataAccessLayer
{
    public class CancellationDataAccessLayer : CancellationDataAccessLayer
    {
        //create list
        List<FlightName> FlightName = new List<FlightName>();

        public void AddFlightName(FlightName FlightName)
        {
            ////code generating new customer id

            //customers.Add(customer);

            //not done
        }
    }
}*/
