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

           new TicketCancellation() { CustomerID = 12345, BookingID = 67890, SeatNumber = 01 },
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
            List<TicketCancellation> _ticketCancellations = JsonConvert.DeserializeObject<List<TicketCancellation>>(str1);
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