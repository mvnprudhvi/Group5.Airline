using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

       //// presentation

using System;
using System.Collections.Generic;

namespace  FlightBooking
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("enter flightName:");
                string flightName = Console.ReadLine();

                Console.Write("enter flight Id:");
                int flightId = int.Parse(Console.ReadLine());

                Console.Write("enter passengerName:");
                string passengerName = Console.ReadLine();

                //Random class generates pseudo Randon numbers
                var random = new Random();
                int RandomNo = random.Next();
                int SeatNumber = RandomNo;

                Console.WriteLine("================== FlightBooking ==========================");
                Console.WriteLine(" flightName :" + flightName);
                Console.WriteLine(" flightId :" + flightId);
                Console.WriteLine(" passengerName :" + passengerName);
                Console.WriteLine(" you are seated in seat number: " + SeatNumber);
                Console.WriteLine("============================================================");

                Console.WriteLine(" flightName   flightId  passengerName Seat Number");
                Console.WriteLine("-----------------------------------------------------");

            }
        }
    }

    