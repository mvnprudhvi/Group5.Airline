public class Airline
{
    private int _FlightNumber;
    private string _View;
    private int _Time;
    private int _Date;
    private string _Cancel;
    public void SetFlightNumber(int value)
    {
        _FlightNumber = value;
    }
    public int FlightNumber()
    {
        return _FlightNumber;
    }
    public void SetView(string value)
    {
        _View = value;

    }
    public string GetView()
    {
        return _View;
    }
    public void SetTime(int value)
    {
        _Time = value;

    }
    public int GetTime()
    {
        return _Time;
    }
    public void SetDate(int value)
    {
        _Date = value;

    }
    public int GetDate()
    {
        return _Date;
    }
    public void SetCancel(string value)
    {
        _Cancel = value;

    }
    public string GetCancel()
    {
        return _Cancel;
    }

}