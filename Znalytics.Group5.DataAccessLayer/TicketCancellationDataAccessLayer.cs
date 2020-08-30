//created by Madhumitha.....
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Znalytics.Group5.Airline.Entities;
/// <summary>
/// represents dataAccessLayer of Ticketcancellation
/// </summary>
namespace Znalytics.Group5.DataAccessLayer
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    public class TicketCancellationDataAccessLayer : ITicketCancellationDataAccessLayer
    {
        private object JsonConvert;

        // creating list
        private static List<TicketCancellation> _cancellationID
        {
            set;
            get;
        }

        static TicketCancellationDataAccessLayer()
        {

            _cancellationID = new List<TicketCancellation>()
            {

           new TicketCancellation() { CustomerID = 12345, BookingID = 67890, SeatNumber = 0  },
         new TicketCancellation() { CustomerID = 12345, BookingID = 23545, SeatNumber = 05  },
          new TicketCancellation() { CustomerID = 12345, BookingID = 67340, SeatNumber = 05 }
            };
        }
        /// <summary>
        /// Saving the data into Json file
        /// </summary>
        public void SaveIntoFile()
        {

            string str = JsonConvert.SerializeObject(_cancellationID);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\FlightSchedule.txt");
            streamWriter.Write(str);
            streamWriter.Close();
        }

        /// <summary>
        /// Method For Getting Data From File
        /// </summary>
        /// <returns></returns>
        public List<TicketCancellation> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\FlightSchedule.txt");
            string str1 = streamReader.ReadToEnd();
            List<TicketCancellation> ticketCancellations = JsonConvert.DeserializeObject<List<TicketCancellation>>(str1);
            return _cancellationID;

        }

        //methods to add ticket cancellation
        public void AddTicketCancellations(TicketCancellation bookingId)
        {
            if (_cancellationID.Exists(temp => temp.CustomerID == bookingId.CustomerID))
            {
                bookingId.CancellationID = bookingId.CustomerID + 45;
                _cancellationID.Add(bookingId);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //methods to update ticket cancellation
        public void UpdateTicketCancellations(TicketCancellation bookingId)
        {
            if (_cancellationID.Exists(temp => temp.CustomerID == bookingId.CustomerID))
            {
                _cancellationID.Update(bookingId);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //method to get ticket cancellation by ticket cancellation id
        public List<TicketCancellation> GetTicketCancellationsByCancellationID(int cancellationID)
        {
            return _cancellationID.FindAll(temp => temp.CancellationID == cancellationID);
        }
        //method to get ticket cancellation by ticket customer id
        public List<TicketCancellation> GetTicketCancellationsByCustomerID(int customerID)
        {
            return _cancellationID.FindAll(temp => temp.CancellationID == customerID);
        }
        //method to get ticket cancellation by ticket booking id
        public List<TicketCancellation> GetTicketCancellationsByBookingID(int bookingID)
        {
            return _cancellationID.FindAll(temp => temp.CancellationID == bookingID);
        }
        /// <summary>
        /// Method to GET the added cancellation id
        /// </summary>
        /// <returns></returns>
        public List<TicketCancellation> GetTicketCancellations()
        {
            return GetTicketCancellations();
        }
    }
}





/*//created by Madhumitha.....
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Znalytics.Group5.Airline.Entities;
/// <summary>
/// represents dataAccessLayer of Ticketcancellation
/// </summary>


namespace Znalytics.Group5.DataAccessLayer
{
    /// <summary>
    /// Represents Business logic layer of the customer personal details
    /// </summary>
    class TicketCancellationDataAccessLayer : ITicketCancellationDataAccessLayer
    {
        // creating list
        private static List<TicketCancellation> _cancellationID
        {
            set;
            get;
            }

        static TicketCancellationDataAccessLayer()
        {

            _cancellationID = new List<TicketCancellation>()
            {

           new TicketCancellation() { CustomerID = 12345, BookingID = 67890, SeatNumber = 01, Date = 2020-08-29, CancellationID = 23 },
          new TicketCancellation() { CustomerID = 12345, BookingID = 23545, SeatNumber = 01, Date = 2020-08-29, CancellationID = 23 },
          new TicketCancellation() { CustomerID = 12345, BookingID = 67890, SeatNumber = 01, Date = 2020-08-29, CancellationID = 23 }
            };
        }
        //methods to add ticket cancellation
        public void AddTicketCancellations(TicketCancellation bookingId)
        {
            if (_cancellationID.Exists(temp => temp.CustomerID == bookingId.CustomerID))
            {
                bookingId.CancellationID = bookingId.CustomerID+45;
                _cancellationID.Add(bookingId);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //methods to update ticket cancellation
        public void UpdateTicketCancellations(TicketCancellation bookingId)
        {
            if (_cancellationID.Exists(temp => temp.CustomerID == bookingId.CustomerID))
            {
                _cancellationID.Update(bookingId);
            }
            else
            {
                //throws exception that booking id doesnot exist
                throw new Exception("bookingId doesnot exists");
            }
        }
        //method to get ticket cancellation by ticket cancellation id
        public TicketCancellation GetTicketCancellationsByCancellationID(int cancellationID)
        {
            return _cancellationID.Find(temp => temp.CancellationID == cancellationID);
        }
        //method to get ticket cancellation by ticket customer id
        public TicketCancellation GetTicketCancellationsByCustomerID(int customerID)
        {
            return _cancellationID.Find(temp => temp.CancellationID == customerID);
        }
        //method to get ticket cancellation by ticket booking id
        public TicketCancellation GetTicketCancellationsByBookingID(int bookingID)
        {
            return _cancellationID.Find(temp => temp.CancellationID == bookingID);
        }
    }
}



        /*//method to display the added booking id
        public List<TicketCancellation> GetTicketCancellations()
        {
            return TicketCancellationDataAccessLayer.CancellationID();
        }
        //method to display ticket cancellation by ticket cancellation id
        public TicketCancellation GetTicketCancellationByCancellationID(int customerId)
        {
            return TicketCancellationDataAccessLayer.GetTicketCancellationByCancellationID(CancellationID);
        }
    }
}


        //represents adding ticket cancellation
        public void AddTicketCancellation(TicketCancellation ticketCancellation)
        {
            _TicketCancellation = Add(ticketCancellation);
        }
        //Updation of  ticket cancellation
        public void UpdateTicketCancellation(TicketCancellation CustomerID)
        {
            //Get matching ticket cancellation based on CustomerId
            TicketCancellation tc = TicketCancellation.Find(temp => temp.CustomerID == customer.CustomerID);
            if (CustomerID != null)
            {
                TicketCancellation.CustomerID = TicketCancellation.CustomerID;
            }
        }
        public TicketCancellation GetTicketCancellationsByCustomerID(int CustomerID)
        {

        }
        public TicketCancellation GetTicketCancellationsByBookingID(int CustomerID)
        {

        }
        public TicketCancellation GetTicketCancellationsByCancellationID(int CustomerID)
        {

        }


            public List<TicketCancellation> GetbookingId()
        {
            return _flights;
        }


        //add date
        public void Adddate(TicketCancellation date)
        {
            _flights.Add(date);
        }

        //Get  date
        public List<TicketCancellation> Getdate()
        {
            return _flights;
        }
        //update date
        public void updatedate(TicketCancellation date)
        {
            _flights.Add(date);
        }
       }

}*/








/*using System.Collections.Generic;
using Znalytics.Group5.AirLine.CancellationModule.Entities;

namespace Znalytics.Group5.AirLine.CancellationDataAccessLayer
{
    public class FlightCancellationDataAccessLayer : CancellationDataAccessLayer
    {
        //create list
        List<FlightName> FlightName = new List<FlightName>();

        public void AddFlightName(FlightName FlightName)
        {
            ////flight generating 

            //flight.Add(flight);

            //not done
        }
    }
}*/
