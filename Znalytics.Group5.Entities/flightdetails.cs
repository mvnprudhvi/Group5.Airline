

public class FlightSchedule

{
    private string _flightName { set; get; }
    private string _flightId { set; get; }
    private string _source { set; get; }
    private string _destination { set; get; }
    private string _departureTiming { set; get; }
    private string _arrivalTiming { set; get; }

    public FlightSchedule(string flightName, string flightId, string source, string destination, string departureTiming, string arrivalTiming)
    {
        _flightName = flightName;
        _flightId = flightId;
        _source = source;
        _destination = destination;
        _departureTiming = departureTiming;
        _arrivalTiming = arrivalTiming;
    }
    public string flightName
    {
        set
        {
            if (value.Length <= 10)
                flightName = value;
        }
        get { return _flightName; }
    }

    public string flightId
    {
        set
        {
            if (value.Length <= 10)
                flightId = value;
        }
        get { return _flightId; }
    }

    public string source
    {
        set
        {
            if (value.Length <= 10)
                source = value;
        }
        get { return _source; }
    }

    public string destination
    {
        set
        {
            if (value.Length <= 10)
                _destination = value;
        }
        get { return _destination; }
    }

    public string departureTiming
    {
        set
        {
            if (value.Length <= 10)
                departureTiming = value;
        }
        get { return _departureTiming; }
    }
    public string arrivalTiming
    {
        set
        {
            if (value.Length <= 10)
                arrivalTiming = value;
        }
        get { return _arrivalTiming; }
    }
}