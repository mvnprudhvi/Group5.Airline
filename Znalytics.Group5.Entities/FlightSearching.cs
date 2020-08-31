using System;
using System.Text.RegularExpressions;
using Znalytics.Group5.Airline.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.FlightSearchingModule.Entities
{
   /* class FlightSearching
    {
        // instance or non-static fields
        private string _flightName { set; get; }
        private string _flightId { set; get; }
        private string _source { set; get; }
        private string _destination { set; get; }
        private DateTime _departureTiming { set; get; }
        private DateTime _arrivalTiming { set; get; }


       /* //flightName Property
        public string flightName;
        public string flightId;
        public string source;
        public string destination;
        public DateTime departureTiming;

        public DateTime arrivalTiming;*/

    }
/*// constructor
public FlightSearching(string flightName, string flightId, string source, string destination, DateTime departureTiming, DateTime arrivalTiming)
{
    _flightName = flightName;
    _flightId = flightId;
    _source = source;
    _destination = destination;
    _departureTiming = departureTiming;
    _arrivalTiming = arrivalTiming; }
  /// <summary>
    /// propery for  flightName
    /// </summary>
    public string FlightName
{

    set
    {
        //Regular Expression for Alphabets(Capital&small letters)
        Regex r = new Regex("[a-zA-Z_]$");
        //FlightName should not be null or empty
        if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
        {
            _flightName = value;

        }

        else
        {
            throw new FlightException("invalid flight name,should not contain spaces and length should not exceed by 30");
        }

    }
    get
    {
        return _flightName;
    }
}

   

    /// <summary>
    /// property for flightId
    /// </summary>
    public string FlightId
    {
        set
        {
            //Regular Expression for AlphaNumeric values
            Regex r = new Regex("[A-Z0-9]$");
            //flightId should not be null or empty
            if (!string.IsNullOrEmpty(value) && value.StartsWith("FID100") && r.IsMatch(value) && value.Length == 6)
            {


                _flightId = value;

            }

            else
            {
                throw new FlightException("Enter valid flight.It should not contain spaces and length be exactly 6");
            }
        }
        get
        {
            return _flightId;

        }

    }
    /// <summary>
    /// from adress of flight i.e., Source
    /// </summary>
    public string Source
    {
        set
        {
            //Regular Expression for Alphabets(Capital&small letters)
            Regex r = new Regex("[a-zA-Z_]+$");
            //LocationName should not be null or empty
            if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
            {

                bool atFound = value.Contains("@");
                bool commaFound = value.Contains(",");
                if (!atFound && !commaFound && value.Length <= 30)
                {
                    _source = value;
                }

            }

            else
            {
                throw new FlightException("destination shouldn't be null and shouldn't contain special characters");
            }
        }
        get
        {
            return _source;
        }
    }


    public string Destination
    {
        set
        {
            //Regular Expression for Alphabets(Capital&small letters)
            Regex r = new Regex("[a-zA-Z_]+$");
            //LocationName should not be null or empty
            if (!string.IsNullOrEmpty(value) && r.IsMatch(value) && value.Length <= 30)
            {
                bool atFound = value.Contains("@");
                bool commaFound = value.Contains(",");
                if (!atFound && !commaFound && value.Length <= 30)
                {
                    _destination = value;
                }
            }

            else
            {
                throw new FlightException("Destination shouldn't be null and shouldn't contain special characters");
            }
        }
        get
        {
            return _destination;
        }
    }


    public DateTime DepartureTiming
    {
        set
        {
            _departureTiming = value;
        }
        get { return _departureTiming; }
    }


    public DateTime ArrivalTiming
    {
        set
        {
            _arrivalTiming = value;
        }
        get { return _arrivalTiming; }
    }

}*/
