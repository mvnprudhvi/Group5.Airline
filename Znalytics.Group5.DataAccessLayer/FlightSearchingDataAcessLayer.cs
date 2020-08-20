

using System.Collections.Generic;

using Znalytics.Group5.Flightsearching.Entities;

namespace Znalytics.Group5.Airline.FlightsearchingDataAccessLayer
{



    public class FlightsearchingDataAccessLogic
    {
        //private fields
        private static List<FlightsearchingDataAccessLogic> _Flightsearching;

        //constructor
        static FlightsearchingDataAccessLogic()
        {
            _Flightsearching = new List<FlightsearchingDataAccessLogic>()
            {
                new Flightsearching(){ FlightID = 102, FlightName= "SpiceJet" },
                new Flightsearching(){ FlightID= 103,FlightName= "AirAsia India" }
            };
        }

        //Add
        public void Add(Flightsearching Flightsearching)
        {
            _Flightsearching.Add(Flightsearching);
        }

        //Get all employees
        public List<Flightsearching> GetFlightsearching()
        {
            return _Flightsearching;
        }

        //Update
        public void UpdateFlightsearching(Flightsearching Flightsearching)
        {
            //Get matching employee based on EmpID
            Flightsearching  fs = _Flightsearching.Find(temp => temp.FlightID == fs.FlightID);
            if (fs != null)
            {
               fs.flightName = Flight.FlightName;
            }
        }
    }

    //
    public class FlightsearchingBusinessLogic
    {
        FlightsearchingDataAccessLogic _FlightsearchingDataAccessLogic;

            public Flightsearching()
            {
            _FlightsearchingDataAccessLogic = new FlightsearchingDataAccessLogic();
            }

            //Add
            public void Add(Employee employee)
            {
                if (employee.EmployeeName != null)
                {
                    _employeesDataAccessLogic.Add(employee);
                }
                else
                {
                    throw new Exception("Employee Name can't be null");
                }
            }

            //GetAllEmployees
            public List<Employee> GetEmployees()
            {
                return _employeesDataAccessLogic.GetEmployees();
            }

            public void UpdateEmployee(Employee employee)
            {
                if (employee.EmployeeName != null)
                {
                    _employeesDataAccessLogic.UpdateEmployee(employee);
                }
            }
        }
    }

//













   // public class FlightSearchingDataAccessLayer
    {
        //create list
        List<FlightName> FlightName = new List<FlightName>();

        public void AddFlightName(FlightName FlightName )
        {

        }
    //}
}
