/// <summary>
/// Created By Dinesh
/// Module Name is FlightPrice
/// </summary>

//This Represents Importing Statements
/*using static System.Console;
using Znalytics.Group5.Airline.Entities;
using Znalytics.Group5.Airline.BusinessLogicLayer;
using System.Collections.Generic;

/// <summary>
/// Creating a namespace for Presentation Layer of Airline Reservation System
/// </summary>
namespace Znalytics.Group5.Airline.PresentationLayer
{
    /// <summary>
    /// This Class Represents Presentation Layer Of FlightPrice
    /// </summary>
    class FlightPricePresentation
    {
        //Creating Reference Variable Of Price Business Logic Layer
        private static IFlightPriceBusinessLogic _flightPriceBusinessLogic;

        /// <summary>
        ///This Represents Execution Starts from Main Method
        /// </summary>
        static void Main()
        {
            //Creating Object of Flight Price Business Logic 
            _flightPriceBusinessLogic = new FlightPriceBusinessLogic();

            //Calling Menu Method For List Of Prices Menus Available in it
            PricesMenu();

            //It waits until the user presses any key on the keyboard and it makes console window wait for user's input
            ReadKey();
        }

        /// <summary>
        /// This Method Represents PriceMenu To View Operations Of FlightPrice
        /// </summary>
        static void PricesMenu()
        {
            int choice = 0;
            bool b;
            //do-While Looping Control Statement  
            //It Executes the Statements inside the Loop and Later it will check Condition
            do
            {
                //This Represents FlightPrice Menu To Select any choice to perform that operation
                WriteLine("=======FlightPRICE MENU=======");
                WriteLine("1. Add Flight Price");
                WriteLine("2. Delete Flight Price");
                WriteLine("3. Update Flight Price");
                WriteLine("4. Update Weekend Hike Perentage By ScheduleId");
                WriteLine("5. Update Weekend Hike Perentage For ALL ScheduleId's");
                WriteLine("6. View Flight Prices By Before Days");
                WriteLine("7. Exit");

                //Reading Choice Manually From User
                Write("Enter Your choice: ");
                //TryPrse is for Perfect Conversion of String to int
                b = int.TryParse(ReadLine(), out choice);
                if (b == true && choice <= 7)
                {
                    //Switch is a Conditional Control Statement 
                    //It Selects Control Mechanism which Executes one after another until the Break Statment occurs
                    switch (choice)
                    {
                        //This Case Represents Method Calling of AddFlightPrice to Add the FlightPrice
                        case 1: AddFlightPrice(); break;

                        //This Case Represents Method Calling of DeleteFlightPrice to Delete the FlightPrice
                        case 2: DeleteFlightPrice(); break;

                        //This Case Represents Method Calling  of UpdateFlightPrice to Update the FlightPrice
                        case 3: UpdateFlightPrice(); break;

                        //This Case Represents Method Calling of UpdateWeekendPriceHikePercentageByScheduleId to update the  Weekend Hike Percentage Based on ScheduleId
                        case 4: UpdateWeekendPriceHikePercentageByScheduleId(); break;

                        //This Case Represents Method Calling of UpdateWeekendPriceHikePercentageForAllSchedules to Update the Weekend Price Hike Percentage For All Schedules
                        case 5: UpdateWeekendPriceHikePercentageForAllSchedules(); break;

                        //This Case Represents Method Calling of GetFlightPricesByBeforeDays to View the FlightPrices Based on Before Days
                        case 6: GetFlightPricesByBeforeDays(); break;
                    }
                }
                else
                {
                    //Displaying Message if User Enter Incorrect Digits 
                    WriteLine("Please Enter only Digit from 1 to 7");
                }

            } while (choice != 7);
        }

        /// <summary>
        /// This Method Represents to Add the Business price and Economy Price of Flight
        /// </summary>
        static void AddFlightPrice()
        {
            //Created an Object for FlightPrice and storing in Reference Variable
            FlightPrice fp = new FlightPrice();

            //Displaying What the user as selected the choice in FlightPrice Menu 
            WriteLine("You Chose to Add FlightPrice");

            try
            {
                //Reading ScheduleId Manually From Admin
                Write("Enter the Schedule Id (Ex.FSID01): ");
                fp.FlightScheduleId = ReadLine();

                //Reading Business Class Seat Price Manually From Admin
                Write("Enter the Price For Business Class Seats: ");
                fp.PriceForBusinessClassSeat = double.Parse(ReadLine());

                //Reading Economy Class Seat Price Manually From Admin
                Write("Enter the Price For Economy Class Seats: ");
                fp.PriceForEconomyClassSeat = double.Parse(ReadLine());

                //Method Calling of AddFlightPrice Method to FlightPriceBusinessLogic
                _flightPriceBusinessLogic.AddFlightPrice(fp);

                //Displaying Message to Admin When FlightPrice is Added Successfully
                WriteLine("The Price of ScheduleId:" + fp.FlightScheduleId + " is Added Successfully\n");
            }
            //Catch Block Represents Displaying Exception Message which was thrown in Validations
            catch (FlightPriceException ex)
            {
                WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// This Method Represents to Delete the Price of Flight
        /// </summary>
        static void DeleteFlightPrice()
        {

            //Created an Object for FlightPrice and storing in Reference Variable
            FlightPrice fpr = new FlightPrice();

            //Displaying What the user as selected the choice in FlightPrice Menu 
            WriteLine("You Chose to  Delete  Flight Price");

            try
            {
                //Reading Existing ScheduleId Manually From Admin
                Write("Enter Existing Flight Schedule Id to Delete the All Prices of That Schedule: ");
                fpr.FlightScheduleId = ReadLine();

                //Method Calling of DeleteFlightPrice Method to FlightPriceBusinessLogic
                _flightPriceBusinessLogic.DeleteFlightPrice(fpr);

                //Displaying Message to Admin When FlightPrice is Deleted Successfully
                WriteLine("The Price of ScheduleId:" + fpr.FlightScheduleId + " is  Deleted Successfully\n");
            }
            //Catch Block Represents Displaying Exception Message which was thrown in Validations
            catch (FlightPriceException ex)
            {
                WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// This Method Represents to Update the Business price and Economy Price of Flight
        /// </summary>
        static void UpdateFlightPrice()
        {
            //Created an Object for FlightPrice and storing in Reference Variable
            FlightPrice fpri = new FlightPrice();

            //Displaying What the user as selected the choice in FlightPrice Menu 
            WriteLine("You Chose to Update Flight Price");
            try
            {
                //Reading Existing ScheduleId Manually From Admin
                Write("Enter Existing Schedule Id (Ex.FSID01): ");
                fpri.FlightScheduleId = ReadLine();

                //Reading Business Class Seat Price Manually From Admin 
                Write("Enter the Price For Business Class Seats: ");
                fpri.PriceForBusinessClassSeat = double.Parse(ReadLine());

                //Reading Economy Class Seat Price Manually From Admin
                Write("Enter the Price For Economy Class Seats: ");
                fpri.PriceForEconomyClassSeat = double.Parse(ReadLine());

                //Method Calling of UpdateFlightPrice Method to FlightPriceBusinessLogic
                _flightPriceBusinessLogic.UpdateFlightPrice(fpri);

                //Displaying Message to Admin When the FlightPrice is Updated Successfully
                WriteLine("The Price of ScheduleId:" + fpri.FlightScheduleId + " is Successfully Updated\n");
            }
            //Catch Block Represents Displaying Exception Message which was thrown in Validations
            catch (FlightPriceException ex)
            {
                WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// This Method Represents to Update the Weekend Hike Percentage Based on Individual ScheduleId 
        /// </summary>
        static void UpdateWeekendPriceHikePercentageByScheduleId()
        {
            //Displaying What the user as selected the choice in FlightPrice Menu 
            WriteLine("You Chose to Update Weekend Hike Perentage By ScheduleId ");
            try
            {
                //Creating Object of Flight Price
                FlightPrice fpri = new FlightPrice();

                //Reading Existing ScheduleId Manually
                Write("Enter Existing Schedule Id (Ex.FSID01): ");
                fpri.FlightScheduleId = ReadLine();

                //Reading weekend hike Percentage  Manually
                Write("Enter Weekend Hike Percentage: ");
                fpri.WeekendPriceHikePercentage = double.Parse(ReadLine());

                //Method Calling  of UpdateWeekendPriceHikePercentageByScheduleId to Business logic Layer
                _flightPriceBusinessLogic.UpdateWeekendPriceHikePercentageByScheduleId(fpri);

                //Displaying Message When the Weekend Hike Perecentage is Added successfully
                WriteLine("The Weekend Hike Percentage of ScheduleId:" + fpri.FlightScheduleId + " is  Updated Successfully\n");

            }
            //Catch Block Represents Displaying Exception Message which was thrown in Validations
            catch (FlightPriceException ex)
            {
                WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// This Method Represents to Update the Weekend Hike Percentage For All ScheduleId's
        /// </summary>
        static void UpdateWeekendPriceHikePercentageForAllSchedules()
        {
            //Displaying What the user as selected the choice in FlightPrice Menu 
            WriteLine("You Chose to Update Weekend Hike Perentage For ALL ScheduleId's ");
            try
            {
                //Reading Weekend Hike Percentage From Admin 
                Write("Enter Weekend Hike Percentage: ");
                double weekendPriceHikePercentage = double.Parse(ReadLine());
                if (weekendPriceHikePercentage > 0 && weekendPriceHikePercentage <= 100)
                {
                    //Method Calling of UpdateWeekendPriceHikePercentageForAllSchedules to Business logic Layer
                    _flightPriceBusinessLogic.UpdateWeekendPriceHikePercentageForAllSchedules(weekendPriceHikePercentage);

                    //Displaying Message When the Weekend Hike Perecentage For All Schedules is Updated Successfully
                    WriteLine("The Weekend Hike Percentage of All ScheduleId's is Successfully Updated\n");
                }
                else
                {
                    throw new FlightPriceException("Please Enter Percentage Between 1 to 100");
                }
            }
            //Catch Block Represents Displaying Exception Message which was thrown in Validations
            catch (FlightPriceException ex)
            {
                WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// This Method Represents to Get the FlightPrices Based on Before Days
        /// </summary>
        static void GetFlightPricesByBeforeDays()
        {
            //Displaying What the user as selected the choice in FlightPrice Menu 
            WriteLine("You Chose to View Flight Prices By Before Days ");
            try
            {
                //Reading  Before Days Manually From User
                Write("Enter before days You  Want Booking in Advance(<=60): ");
                int beforedays = int.Parse(ReadLine());

                //Creating Reference Variable of List<FlightPrice> to get the Data from List
                List<FlightPrice> prs;

                // Method Calling of GetFlightPricesByBeforeDays to Business Logic Layer through Reference Variable of List<FlightPrice>
                prs = _flightPriceBusinessLogic.GetFlightPricesByBeforeDays(beforedays);

                //Dispalying  Details of FligthId,Before Days,Hike Perecentage,Business Class Seats,Economy Class Seats Of FlightPrices
                WriteLine("=========FLIGHTS SCHEDULED PRICE DETAILS ARE BELOW=======");
                WriteLine("FlightScheduleId" + "  BeforeDays" + "  HikePercentage" + "  BusinessClassSeats" + "  EconomyClassSeats");
                WriteLine("-------------------------------------------------------------------------------------");

                //foreach Loop is For Retreiving the data from List<FlightPrice> Collection by Using Reference Variable
                foreach (FlightPrice pri in prs)
                {
                    WriteLine("   " + pri.FlightScheduleId + "\t\t" + beforedays + "     \t" + pri.WeekendPriceHikePercentage + "%" + "\t\t" + pri.PriceForBusinessClassSeat + " \t\t\t" + pri.PriceForEconomyClassSeat);
                }

                //This Represents Giving one Line Space after this operation is Done
                WriteLine();
            }
            //Catch Block Represents Displaying Exception Message which was thrown in Validations
            catch (FlightPriceException ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}