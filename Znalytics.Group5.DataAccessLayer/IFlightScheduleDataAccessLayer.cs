using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group5.Airline.FlightScheduleModule.Entities;

namespace Znalytics.Group5.DataAccessLayer
{
    interface IFlightScheduleDataAccessLayer
    {
        void Addchedule(FlightSchedule fs);
        void RemoveFlightScheduleByFlightId(FlightSchedule fs);
        int GetSchedule(FlightSchedule fs);

    }
}

        
