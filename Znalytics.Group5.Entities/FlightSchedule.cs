//.......KEERTHANA..........

//Entities
namespace Znalytics.Group5.Airline.Entities
{

    // creating a class "FlightSchedule"
    public class FlightSchedule

    {
        //Private Fields

       
        private string _source { set; get; }
        private string _destination { set; get; }
        private string _departureTiming { set; get; }
        private string _arrivalTiming { set; get; }

        //constructor
        public FlightSchedule( string Source, string Destination, string DepartureTiming, string ArrivalTiming)
        {
           
            _source = Source;
            _destination = Destination;
            _departureTiming = DepartureTiming;
            _arrivalTiming = ArrivalTiming;
        }

        //properties
        
          
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