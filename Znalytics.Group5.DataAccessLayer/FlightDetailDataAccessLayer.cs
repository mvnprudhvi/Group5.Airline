using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.Airline.DataAccessLayer
{
    class FlightDetailDataAccessLayer
    {
        //create list
        List<Flight> flight = new List<Flight>();

        public void AddFlight(Flight flight)
        {
            ////code generating new flight 
            Console.Write("Enter flight name to be added: ");
             string userinput = Console.ReadLine();
             if(userinput != "null")
             {
                 flight.Add(userinput);
                 foreach (object obj in flight)
                     Console.Write(obj.ToString() + " ");
             }
             else
             {
                 Console.Write("not allowed");
             }
            
            
        }
    }
}
