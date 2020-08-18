
/// <summary>
/// Represents Flight
/// </summary>
public class Flight
{
    //private fields
    private string _FlightName;
    private System.DateTime _Date;
    private System.DateTime Time;
    private string _Cancel;

    /// <summary>
    /// Constructor that initializes details of cancellation
    /// </summary>
    /// <param name="FlightName">Represents flight number</param>
    /// <param name="Date">represents date of flight</param>
    /// <param name="Time">represents time of flight</param>
    /// <param name="cancel">represents cancellation of flight</param>
    public Flight(string FlightName, System.DateTime _Date, System.DateTime _Time, string cancel)
    {
        //_FlightName = flightName;
        //_Date = date;
        //_Time = time;
        //_Cancel = cancel;

        _FlightName = FlightName; //set method will be called
        //_Date = date; //set method will be called
        //_Time = time; //set method will be called
        _Cancel = cancel; //set method will be called

    }

    /// <summary>
    /// Parameterless constructor
    /// </summary>
    public Flight()
    {
        //not initializing
    }


    /// <summary>
    /// Static constructor
    /// </summary>


    /// <summary>
    /// Represents name of the AirLine
    /// </summary>
    public string FlightName
    {
        set
        {
            //Name should be less than 30 stringacters
            if (value.Length <= 30)
            {
                _FlightName = value;
            }
        }

        get
        {
            return _FlightName;
        }
    }

    /// <summary>
    /// date of flight
    /// </summary>
    public System.DateTime date
    {
        set
        {
            _Date = value;
        }
    }
    public string Cancel
    {
        set
        {
            if (value.Length <= 30)
                _Cancel = value;
        }
        get
        {
            return _Cancel;
        }
    }
}




/*namespace Znalytics.Airline.CancellationModule.Entitie
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

/*{
    private string _FlightName;
    private System.DateTime _Date;
    private System.DateTime _Time;
    private bool _Cancel;


    public string FlightName
    {
        set
        {
            if (value.Length <= 30)
            {
                _FlightName = value;
            }
        }
        get
        {
            return _FlightName;
        }
    }
    public string Cancel
    {
        set
        {
            if (value.Length <= 30)
            {
                _Cancel = value;
            }
        }
        get
        {
            return _Cancel;
        }
    }



    /*public System.DateTime _Date;
            {
                set
                {
                    _Date = value;
                }
                get
                {
                    return _Date;
                }
            }
    public System.DateTime _Date;
            {
                set
                {
                    _Date = value;
                }
                get
                {
                    return _Date;
                }
            }


    public override string ToString()
    {
        return base.ToString() + "FlightName: " + FlightName + ", Cancel: " + Cancel;
    }

    public override int GetHashCode()
    {
        return 1000;
    }*/






       /* public class Flight
{
    private string _FlightName;
    private System.DateTime _Date;
    private System.DateTime _Time;
    private string _Cancel;

    public void SetFlightName(string FlightName)
    {
        this._FlightName = FlightName;
    }
    public string GetFlightName()
    {
        return this._FlightName;
    }
    public void SetDate(System.DateTime Date)
    {
        this._Date = Date;
    }
    public string GetDate()
    {
        return this._FlightName;
    }
    public void SetCancel(string Cancel)
    {
        this._Cancel = Cancel;
    }
    public string GetCancel()
    {
        return this._Cancel;
    }
}

/*public void SetTime(System.DateTime Time)
{
    this._Time = Time;
}
public System.DateTime GetDate()
{
    return this._Time;
}
}*/




