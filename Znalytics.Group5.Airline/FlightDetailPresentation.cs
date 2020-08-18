using System;
using System.Collections.Generic;

namespace Znalytic.Group5.Airline.FlightModule.PresentationLayer
{
    class FlightDetailPresentation
    {
       


        class Program
        {
            private static string[,] flightName = new string[2, 2];
            private static int[,] flightId = new int[2, 2];
            private static string[,] source = new string[2, 2];
            private static string[,] destination = new string[2, 2];
            private static string[,] departureTiming = new string[2, 2];
            private static string[,] arrivalTiming = new string[2, 2];


            // Row and Coloumn is used display the flight details in table format
            public static void PrintDetails()
            {
                for (int row = 0; row <= 2; row++)
                {
                    for (int coloumn = 0; coloumn <= 2; coloumn++)
                    {
                        if (flightName[row, coloumn] == null)
                            return;
                        else
                        {
                            System.Console.WriteLine(flightName[row, coloumn] + "\t\t" + flightId[row, coloumn] + "\t\t" + source[row, coloumn] + "\t\t" + destination[row, coloumn] + "\t\t" + departureTiming[row, coloumn] + "\t\t" + arrivalTiming[row, coloumn]);
                        }
                    }
                }
            }

            static void Main()
            {


                for (int row = 0; row <= 2; row++)
                {
                    for (int coloumn = 0; coloumn <= 2; coloumn++)
                    {

                        // Enter the details of Flight

                        System.Console.Write("Enter FlightName:"); //Name of the Flight
                        flightName[row, coloumn] = System.Console.ReadLine();

                        System.Console.Write("Enter FlightId:"); // enter flight id
                        flightId[row, coloumn] = int.Parse(System.Console.ReadLine());

                        System.Console.Write("Enter source:"); // Enter FROM Address
                        source[row, coloumn] = System.Console.ReadLine();

                        System.Console.Write("Enter destination:"); //enter To Addrress
                        destination[row, coloumn] = System.Console.ReadLine();

                        //DateTime used to represent date and time of the Day

                        System.Console.WriteLine("enter Departure Timing:"); //
                        var userDate = System.Console.ReadLine();
                        System.DateTime UserDateTime;  //  DateTime is of type DateTime Datatype
                        if (System.DateTime.TryParse(System.Console.ReadLine(), out UserDateTime))
                        {
                            System.Console.WriteLine("the day of the week is:" + UserDateTime.DayOfWeek);
                        }
                        else
                        {
                            System.Console.WriteLine("you have entered an incorrect value:");
                        }
                        System.Console.ReadLine();
                        departureTiming[row, coloumn] = System.Console.ReadLine();



                        System.Console.WriteLine("enter Arrival Timing:");
                        var inputtedDate = System.Console.ReadLine();
                        System.DateTime result;
                        System.DateTime.TryParse(inputtedDate, out result);
                        arrivalTiming[row, coloumn] = System.Console.ReadLine();



                        // Display the Flight Details

                        System.Console.WriteLine("---------------FLIGHT SCHEDULE---------------------------------------------");

                        System.Console.WriteLine("flightName:" + flightName[row, coloumn]);
                        System.Console.WriteLine("flightId:" + flightId[row, coloumn]);
                        System.Console.WriteLine("source:" + source[row, coloumn]);
                        System.Console.WriteLine("destination:" + destination[row, coloumn]);
                        System.Console.WriteLine("departureTiming:" + departureTiming[row, coloumn]);
                        System.Console.WriteLine("arrivalTiming:" + arrivalTiming[row, coloumn]);

                        System.Console.WriteLine("--------------------------------------------------------------------------------------------");

                        System.Console.WriteLine("--------------------SCHEDULE LIST------------------------------------------------------------");
                        System.Console.WriteLine("flightName    flightId      source       destination     departureTiming       arrivalTiming");


                        System.Console.WriteLine("----------------------------------------------------------------------------------------------");
                        PrintDetails();
                    }

                }

                int userInput = 0;
                do
                {

                    MenuPresenterr.Menu();

                } while (userInput != 5);// do not enter '5', the code will executes in loop.


            }
        }
    }
}
