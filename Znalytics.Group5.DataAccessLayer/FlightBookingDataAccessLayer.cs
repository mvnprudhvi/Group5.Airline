// created by Reshma
// DataAccessLayer
//module:FlightBooking




using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Znalytics.Group5.Airline.Entities;
using Newtonsoft.Json;
namespace Znalytics.Group5.DataAccessLayer
{



    /// <summary>
    /// Represents Business logic layer of the FlightBooking details
    /// </summary>
  public  class FlightBookingDataAccessLayer : IFlightBookingDataAccessLayer


    {
        //Created an object for datalayer and stored it in reference variable
        FlightBookingDataAccessLayer fbdl = new FlightBookingDataAccessLayer();
       

        //creating list
        private static List<FlightBooking>_bookingList
        {
            set;
            get;
        }

        //constructor

       
     static FlightBookingDataAccessLayer()
           {

               _bookingList = new List<FlightBooking>()
                    {

          new FlightBooking() { FlightID = 12, CustomerID = 12345, BookingID = 67890, SeatNumber = 01,PassengerName = "xxx", Source = "hyderabad", Destination  = "Mumbai"},
          new FlightBooking() { FlightID = 13, CustomerID = 5678, BookingID  = 78901, SeatNumber = 02, PassengerName = "yyy", Source = "Mumbai", Destination  = "chennai"},
          new FlightBooking() { FlightID = 14,  CustomerID = 8901, BookingID  = 8760, SeatNumber = 03, PassengerName  = "zzzz",Source = "pune", Destination  = "Hyderabad" }
                      
                    };
           }


        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        public void SaveIntoFile()
        {

            string str = JsonConvert.SerializeObject(_bookingList);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\FlightBooking.txt");
            streamWriter.Write(str);
            streamWriter.Close();
        }

        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public List<FlightBooking> GetFileData()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\FlightBooking.txt");
            string str1 = streamReader.ReadToEnd();
            List<FlightBooking> _bookingList = JsonConvert.DeserializeObject<List<FlightBooking>>(str1);
            return _bookingList;

        }

       
        //methods to add FlightBooking
        public void AddFlightBooking(FlightBooking Booking)
        {
            if (_bookingList.Exists(temp => temp.CustomerID == Booking.CustomerID))
            {



                _bookingList.Add(Booking);
            }

            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId not added");
            }
        }

        public void UpdateFlightBooking(FlightBooking Booking)
        {

            try
            {
                //FlightScheduleId should not be null
                if (Booking.BookingID != 0)
                {
                    //Calls the UpdateSource Method of flightSchedule Data Layer
                    fbdl.UpdateFlightBooking(Booking);
                }
            }
            catch (FlightException ex)
            {
                throw new FlightException(ex.Message);
            }

        }


       /* public void UpdateFlightBooking(FlightBooking bookingID)
        {
            


                FlightBooking fb = _bookingList.Find(temp => temp.BookingID == bookingID);
            if (fb != null)
            {
                fb.DepartureTiming = schedule.DepartureTiming;


            }*/

    /* //methods to update  FlightBooking
     public void UpdateFlightBooking(FlightBooking bookingID)
     {
         if (_bookingList.Exists(temp => temp.CustomerID == bookingID.CustomerID))

         {
            _bookingList.Update(bookingID);
         }
         else
         {
             //throws exception that booking id doesnot exist
             throw new Exception("bookingId doesnot exists");
         }
     }*/

    //method to get  FlightBooking by  Flight Bookingid
    public List<FlightBooking> GetFlightBookingsByFlightBookingID(int bookingID)
        {
            return _bookingList.FindAll(temp => temp.BookingID == bookingID);
        }
        //method to get  FlightBooking by  customer id
        public List<FlightBooking>  GetFlightBookingsByFlightCustomerID(int customerID)
        {
            return _bookingList.FindAll(temp => temp.CustomerID == customerID);
        }
        //method to get  FlightBookinging by  flightid
        public List<FlightBooking> GetFlightBookingsByFlightID(int flightID)
        {
            return _bookingList.FindAll(temp => temp.FlightID == flightID);
        }
    }
}



 /*/// <summary>
/// Represents  class of flightbooking
/// </summary>

class FlightBookingDataAccessLayer : IFlightBookingDataAccessLayer
    {
        // creating  list
        private static List<FlightBooking> _FlightBooking = new List<FlightBooking>();

        //adding  bookingid
        public void AddFlightBooking(FlightBooking bookingID)
        {
            _FlightBooking.Add(bookingID);
        }
       
        // get  all bookings
        public List<FlightBooking> GetBookings()
        {
            return _bookings;
        }
  
        public void UpdateFlightBooking(FlightBooking CustomerID)
        {
            {
                //Get matching FlightBooking based on CustomerId
                FlightBooking fb = FlightBooking.Find(temp => temp.CustomerID == customer.CustomerID);
                if (CustomerID != null)

                    FlightBooking.CustomerID = FlightBooking.CustomerID;
            }
        }

        public FlightBooking GetFlightBookingsByFlightBookingID(int FlightBookingID)
        {

        }
        public FlightBooking GetFlightBookingsByFlightID(int FlightID)
        {

        }


    }
}*/

