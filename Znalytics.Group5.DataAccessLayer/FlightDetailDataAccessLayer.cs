using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightDetailModule.Entities;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    class FlightDetailDataAccessLayer
    {
        //create list
        List<Flight> flight = new List<Flight>();
        private IEnumerable<string> flightName;

        public void AddFlight(Flight flight)
        {
            ////code generating new flight 
            Console.Write("Enter flight name to be added: ");
             string userinput = Console.ReadLine();
             if(userinput != "null")
             {
                 flight.Add(userinput);
                 foreach (string obj in flightName)
                     Console.Write(obj.ToString() + " ");
             }
             else
             {
                 Console.Write("not allowed");
             }
            
            
        }
    }
}
