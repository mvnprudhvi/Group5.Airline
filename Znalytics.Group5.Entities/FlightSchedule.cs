//.......KEERTHANA..........

//Entities
using System;

namespace Znalytics.Group5.Airline.FlightScheduleModule.Entities
{

    // creating a class "FlightSchedule"
    public class FlightSchedule

    {
        //Private Fields
        private int _scheduleNumber { set; get; }
        private string _source { set; get; }
        private string _destination { set; get; }
        private string _departureTiming { set; get; }
        private string _arrivalTiming { set; get; }

        //constructor
        public FlightSchedule( int ScheduleNumber, string Source, string Destination, string DepartureTiming, string ArrivalTiming)
        {
            _scheduleNumber = ScheduleNumber;
            _source = Source;
            _destination = Destination;
            _departureTiming = DepartureTiming;
            _arrivalTiming = ArrivalTiming;
        }

        //properties
        public int ScheduleNumber
        {
            set
            {
                if (ScheduleNumber != 0s)
                {
                    _scheduleNumber = value;
                }
                else
                {
                    Console.WriteLine("schedule number can't be null");
                }
            }
            get { return _scheduleNumber; }
        }

        public string Source
        {
            set
            {

                _source = value;
            }
            get { return _source; }
        }


        public string Destination
        {
            set
            {

                _destination = value;
            }
            get { return _destination; }
        }


        public string DepartureTiming
        {
            set
            {
                _departureTiming = value;
            }
            get { return _departureTiming; }
        }


        public string ArrivalTiming
        {
            set
            {
                _arrivalTiming = value;
            }
            get { return _arrivalTiming; }
        }

    }
}