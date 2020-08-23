//created by Madhumitha
using System;

namespace Znalytics.Group5.Entities
{
    public class FlightCancellation
    {

        public int _FlightName { get; set; }

        public int _FlightID { get; set; }

        public string _Date { get; set; }

        public string _Time { get; set; }

        public string _Cancel { get; set; }
        /// <summary>
        /// Constructor that initializes details of cancellation
        /// </summary>
        /// <param name="FlightName">Represents flight number</param>
        /// <param name="FlightID">represents flight Id</param>
        /// <param name="Date">represents date of flight</param>
        /// <param name="Time">represents time of flight</param>
        /// <param name="cancel">represents cancellation of flight</param>

        public FlightCancellation(int FlightName, string FlightID, System.DateTime _Date, System.DateTime _Time, string _Cancel)
        {
            //    this.FlightName = FlightName;
            //    this.FlightID = FlightID;
            //    this.Date = Date;
            //    this.Time = Time;
            //    this.Cancel = Cancel;
            _FlightName = flightName; //set method will be called
            _FlightID = flightID;//set method will be called
            _Date = date; //set method will be called
            _Time = time;//set method will be called
            _Cancel = cancel;//set method will be called
        }
        /// <summary>
        /// Represents name of the FlightName
        /// </summary>
        //properties
        public string flightName
        {
            set //set the value
            {

                _flightName = value;
            }
            get // get the value
            {

                return _flightName;
            }
        }


        public string flightId
        {
            set //set the value
            {

                _flightId = value;
            }
            get // get the value
            {
                return _flightId;
            }
        }
        /// <summary>
        /// date of flightcancellation
        /// </summary>
        public string date
        {
            set // set the value
            {
                _date = value;
            }
            get // get the value
            {
                return _date;
            }
        }
        /// <summary>
        /// time of flightcancellation
        /// </summary>
        public string Time
        {
            set // set the value
            {
                _time = value;
            }
            get // get the value
            {
                return _time;
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




