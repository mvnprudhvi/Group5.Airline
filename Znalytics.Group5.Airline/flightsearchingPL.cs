//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Znalytics.Group5.Airline

{
    class FlightSearchingPL
    {
            static void Main()
            {
               // FlightSearching f = new FlightSearching();
                System.Console.WriteLine("FlightSearching......");
                System.Console.WriteLine("enter the flight number......");
                f.SetNoOfFlight(int.Parse(System.Console.ReadLine()));
                System.Console.WriteLine(f.GetNoOfFlight());
                System.Console.WriteLine("enter flight name......");
                f.SetFlightName(System.Console.ReadLine());
                System.Console.WriteLine(f.GetFlightName());
                System.Console.WriteLine("enter flight date.....");
                f.SetFlightDate(int.Parse(System.Console.ReadLine()));
                System.Console.WriteLine(f.GetFlightDate());
                System.Console.WriteLine("enter flight time......");
                f.SetTime(int.Parse(System.Console.ReadLine()));
                System.Console.WriteLine(f.GetTime());
                //System.Console.ReadKey();
            }
        }

    }
}
