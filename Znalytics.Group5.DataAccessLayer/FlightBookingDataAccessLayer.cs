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
using Znalytics.Group5.Airline.FlightBooking.Entities;

namespace Znalytics.Group5.DataAccessLayer
{



    /// <summary>
    /// Represents Business logic layer of the FlightBooking details
    /// </summary>
  public  class FlightBookingDataAccessLayer : IFlightBookingDataAccessLayer

    {
        private object JsonConvert;

        //creating list
        private static List<FlightBooking>_bookingID
        {
            set;
            get;
        }

        //constructor

       
     static FlightBookingDataAccessLayer()
           {

               _bookingID = new List<FlightBooking>()
                    {

          new FlightBooking() { FlightID = 12, CustomerID = 12345, BookingID = 67890, SeatNumber = 01, Source = "hyderabad", Destination  = "Mumbai"},
          new FlightBooking() { FlightID = 13, CustomerID = 5678, BookingID  = 78901, SeatNumber = 02, Source = "Mumbai", Destination  = "chennai"},
          new FlightBooking() { FlightID = 14,  CustomerID = 8901, BookingID  = 8760, SeatNumber = 03,Source = "pune", Destination  = "Hyderabad" }
                      
                    };
           }


        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        public void SaveIntoFile()
        {

            string str = JsonConvert.SerializeObject(_bookingID);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\FlightBooking.txt");
            streamWriter.Write(str);
            streamWriter.Close();
        }

        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public List<FlightBooking> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\FlightSchedule.txt");
            string str1 = streamReader.ReadToEnd();
            List<FlightBooking> _flightBooking = JsonConvert.DeserializeObject<List<FlightBooking>>(str1);
            return _bookingID;
        }

       
        //methods to add FlightBooking
        public void AddFlightBooking(FlightBooking bookingID)
        {
            if (_bookingID.Exists(temp => temp.CustomerID == bookingID.CustomerID))
            {



                _bookingID.Add(bookingID);
            }

            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingIdnot added");
            }
        }
        //methods to update  FlightBooking
        public void UpdateFlightBooking(FlightBooking bookingID)
        {
            if (_bookingID.Exists(temp => temp.CustomerID == bookingID.CustomerID))
            
            {
               _bookingID.Update(bookingID);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //method to get  FlightBooking by  Flight Bookingid
        public FlightBooking GetFlightBookingsByFlightBookingID(int bookingID)
        {
            return _bookingID.Find(temp => temp.BookingID == bookingID);
        }
        //method to get  FlightBooking by  customer id
        public FlightBooking GetFlightBookingsByFlightCustomerID(int customerID)
        {
            return _bookingID.Find(temp => temp.CustomerID == customerID);
        }
        //method to get  FlightBookinging by  flightid
        public FlightBooking GetFlightBookingsByFlightID(int flightID)
        {
            return _bookingID.Find(temp => temp.FlightID == flightID);
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

