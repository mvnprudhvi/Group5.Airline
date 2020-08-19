
//Entities
namespace Znalytics.Group5.Airline.FlightsModule.Entities
{
    public class FlightDetail

    {
        //Private Fields

        private string _flightName { set; get; }
        private string _flightId { set; get; }
        private string _source { set; get; }
        private string _destination { set; get; }
        private string _departureTiming { set; get; }
        private string _arrivalTiming { set; get; }

        public FlightDetail(string flightName, string flightId, string source, string destination, string departureTiming, string arrivalTiming)
        {
            _flightName = flightName;
            _flightId = flightId;
            _source = source;
            _destination = destination;
            _departureTiming = departureTiming;
            _arrivalTiming = arrivalTiming;
        }

        //properties
        public string flightName
        {
            set
            {

                _flightName = value;
            }
            get { return _flightName; }
        }


        public string flightId
        {
            set
            {

                _flightId = value;
            }
            get { return _flightId; }
        }

        public string source
        {
            set
            {

                _source = value;
            }
            get { return _source; }
        }


        public string destination
        {
            set
            {

                _destination = value;
            }
            get { return _destination; }
        }


        public string departureTiming
        {
            set
            {
                _departureTiming = value;
            }
            get { return _departureTiming; }
        }


        public string arrivalTiming
        {
            set
            {
                _arrivalTiming = value;
            }
            get { return _arrivalTiming; }
        }

    }
}