using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.DataAccessLayer;
using Znalytics.Group5.Airline.Entities;

namespace Znalytic.Group5.Airline.BussinessLogicLayer
{
    public class FlightDetailBusinessLogic : IFlightDetailBusinessLogic
    {
        FlightDetailsDataAccessLogic _fDal;

        public FlightDetailBusinessLogic()
        {
            _fDal = new FlightDetailsDataAccessLogic();
        }

        //Add
        public void AddflightName(FlightDetail fname)
        {
            if (fname.flightName != null)
            {
                _fDal.AddAddflightName(fname);
            }
            else
            {
                throw new Exception("Flight Name should not be null");
            }
        }
        //GetAll Flights
        public List<flightName> GetflightName()
        {
            return  _fDal.GetflightName();
        }

        public void UpdateflightId(FlightDetail fid)
        {
            if (fid.flightId != null)
            {
                _fDal.UpdateFlightId(fid);
            }
            else
            {
                throw new Exception("flight id can't be null ");
            }
        }
    }
}





