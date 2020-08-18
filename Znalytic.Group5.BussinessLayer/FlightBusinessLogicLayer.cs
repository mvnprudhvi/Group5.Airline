using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytic.Group5.BussinessLayer
{
    class FlightBusinessLogicLayer
    {
        public static void AddFlight()
        {
            string userinput = Console.ReadLine();
            if (userinput != "null")
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
