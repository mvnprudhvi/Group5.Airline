public class Flight

{
    private string _flightName;
    private int _flightId;
    private string _sourseStatioin;
    private string _destinationStation;
    private string _departureDate;
    private string _departureTime;

    public void SetFlightName(string value)
    {
        if (value.Length <= 30)
        {
            _flightName = value;
        }
    }
    public string GetflightName()
    {
        return _flightName;
    }
    public void SetFlighhtId(int value)
    {
        _flightId = value;
    }
    public int GetflightId()
    {
        return _flightId;
    }
    public void SetdepartureDate(string value)
    {
        _departureDate = value;
    }
    public string GetdepartureDate()
    {
        return _departureDate;
    }
    public void SetdepartureTime(string value)
    {
        _departureTime = value;
    }
    public string GetdepartureTime()
    {
        return _departureTime;
    }

}