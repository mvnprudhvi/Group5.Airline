using System;
using System.Collections.Generic;
using Znalytics.Group5.Airline.FlightSearchingbussinessLogicLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group5.Airline
{
    class FlightSearchingPresentation
    {
        /// <summary>
        /// This Class Represents Presentation Layer Of Price
        /// </summary>
        class FlightSearchingPresentation
        {

            private static FlightSearchingbusinessLogic _flightSearchingbusinessLogic;
            private static IEnumerable<FlightSearchingPresentation> _flightSearching;

            /// <summary>
            /// Main Method
            /// </summary>
            static void Main()
            {
                _flightSearchingbusinessLogic = new FlightSearchingbusinessLogic();
                //Calling Menu Method For List Of Menus
                FlightSearchingMenu();
                Console.ReadKey();
            }

            /// <summary> 
            /// This Method Represents PriceMenu To View Operations Of Price
            /// </summary>
            static void FlightSearchingMenu()
            {
                int choice = 0;
                do
                {
                    Console.WriteLine(" ================== FLIGHT BOOKING========================== ");
                    Console.WriteLine("1. Add FlightSearching");
                    Console.WriteLine("2. Update FlightSearching");
                    Console.WriteLine("3. Delete FlightSearching");
                    Console.WriteLine("4. Get FlightSearching");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Your choice: ");
                    choice = int.Parse(ReadLine());
                    //represents switch case
                    switch (choice)
                    {
                        case 1: AddFlightSearching(); break;
                        case 2: UpdateFlightSearching(); break;
                       // case 3: DeleteFlightSearching(); break;
                        case 4: GetFlightSearchings(); break;
                    }
                } while (choice != 5);
            }

            private static string ReadLine()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// This Method Represents adding of flight bookings
            /// </summary>
            static void AddFlightSearching()
            {
                _flightSearching fb = new _flightSearching();

                Console.Write("Enter flight id: ");
                fb.FlightID = int.Parse(ReadLine());

                Console.Write("Enter flightName ");
                fb.flightName= int.Parse(ReadLine());

                _flightSearchingbusinessLogic.AddFlightSearching(fb);

                Console.WriteLine("The details of FlightSearching is Successfully Added \n");
            }



            /// <summary>
            /// This Method Represents Updatation of FlightBooking
            /// </summary>
            static void UpdateFlightSearching()
            {

                _flightSearching fb = new _flightSearching();

                Console.Write("Enter Existing flight id: ");
                fb.flightID = int.Parse(ReadLine());

                Console.Write("Enter existing flightName");
                fb.flightName= int.Parse(ReadLine());

                _flightSearchingbusinessLogic.UpdateFlightSearching(fb);
                Console.WriteLine("The Searching of Flight is Updated Successfully \n");
            }

           /* /// <summary>
            /// This Method Represents Delete FlightBooking by booking
            /// </summary>
            static void DeleteFlightBooking()
            {

                _flightSearching fb = new _flighSearching();
                Console.Write("Enter Existing booking id to Delete FlightSearching ");
                _flightSearchingbusinessLogic.DeleteFlightBooking(fb);
                Console.WriteLine("The FlightSearching is Deleted Successfully \n");
            }*/


            /// <summary>
            /// This Method Represents getting all details of  FlightBooking
            /// </summary>
            static void GetFlightSearchings()
            {

                object _flightSearchinggbusinessLayer = null;
                List<FlightSearching> fb = _flightSearchingbusinessLayer.GetFlightSearching();

                foreach (_flightSearching fb in _flightSearching)
                {
                    Console.Write("=====The FlightSearching  are Below=====");
                    Console.WriteLine("The flightId is " + fb.flightId);
                    Console.WriteLine("The flightName id is " + fb.flightName);
                    Console.WriteLine("The Source is " + fb.Source);
                    Console.WriteLine("The Destination id is " + fb.Destination);
                }
            }
        }
    }


}

