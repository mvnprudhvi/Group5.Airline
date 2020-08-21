using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytics.Group5.BusinessLogicLayer
{
    public class FlightcancellationBusinessLogiclayer
    {
        FlightCancellationDataAccessLayer = _flightcancellationdataAccessLayer;
            {
        public FlightCancellationBusinessLogicLayer()
        {
            _FlightCancellationDataAccessLayer = new FlightCancellationDataAccessLayer();
        }

        //Add
        public void Add(FlightCancellationDataAccessLayer flight)
        {
            if (flightCancellation.FlightName != null)
            {
                _FlightCancellationDataAccessLayer.Add(flight);
            }
            else
            {
                throw new Exception("Flight Name can't be null");
            }
        }

        //GetAllEmployees
        public List<FlightcancellationBusinessLogicLayer> GetFlight()
        {
            return _FlightDataAccessLogic.GetFlight();
        }

        public void UpdateFlightCancellation(FlightCancellationDataAccessLayer flight)
        {
            if (FlightCancellationDataAccessLayer.flight != null)
            {
                _FlightCancellationDataAccessLayer.UpdateFlightName(FlightName);
            }
        }
    }
}





























/*using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.DataAccessLayer;

namespace Znalytics.AirLine.BusinessLogicLayer
{
    public class CancellationBusinessLogicLayer : CancellationBusinessLogicLayer
    {
        private CancellationDataAccessLayer cdl = null;

        public CancellationBusinessLogicLayer()
        {
            cdal = new CancellationDataAccessLayer();
        }

        public void AddFlightName(FlightName FlightName)
        {
            if (FlightName.FlightName != null)

                cdal.AddFlightName(FlightName);
        }
    }
}*/










/*//using system.Znalytic.Group5.BussinessLayer
    public  class FlightBussinessLayer
    {
        public void AddFlight(Flight fn)
    {
        if(Flight.FlightName<=30)
        {
            FlightBussinessLayer fdl = new FlightBussinessLayer()
        }
    }
