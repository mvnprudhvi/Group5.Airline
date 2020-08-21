using System;

namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// Represents Customer
    /// </summary>

    public class Customer
    {

        //private fields
        private string _userName;
         
        private string _email;
        private string _password;
        private int _mobileNumber;

        private int _aadharNumber;
        private string _pancardNumber;

        /// <summary>
        /// constructors thst initializes deatails of customer
        /// </summary>

        public Customer(string userName,string email, string password, int mobileNumber, int aadharNumber, string pancardnumber)
        {

            /// <param name="email"></param> email of customer
            /// <param name="password"></param> password of customer
            /// <param name="mobileNumber"></param> mobile number of customer
            /// <param name="aadharNumber"></param> aadhar number of customer
            /// <param name="pancardnumber"></param> pan card number of customer

            _userName = userName;
             
            _email = email;
            _password = password;
            _mobileNumber = mobileNumber;

            _aadharNumber = aadharNumber;
            _pancardNumber = pancardnumber;
        }
        /// <summary>
        /// represents email of the customer
        /// </summary>
        public string UserName
        {
            set
            {
                if (value.Length <= 10)
                    UserName = value;
            }
            get
            {
                return _userName;
            }
        }

        public string Email
        {
            set
            {
                if (value.Length <= 20)
                    Email = value;
            }
            get
            {
                return _email;
            }
        }
        /// <summary>
        /// represents password of the customer 
        /// </summary>
        public string Password
        {
            set
            {
                if (value.Length <= 10)
                    Password = value;
            }
            get
            {
                return _password;
            }
        }
        /// <summary>
        /// represents number of the customer
        /// </summary>
        public int MobileNumber
        {
            set
            {
                //mobile number should contain 10 digits only
                if (value == 10)
                {
                    MobileNumber = value;
                }
                else
                {
                    throw new Exception("Mobile number should contain 10 digits only");
                }
            }
            get
            {
                return MobileNumber;
            }
        }

        /// <summary>
        /// represents aadhar card number of customer
        /// </summary>
        public int AadharNumber
        {
            set
            {
                if (value == 12)
                    AadharNumber = value;
            }
            get
            {
                return AadharNumber;
            }
        }
        /// <summary>
        /// represents pan card number of customer
        /// </summary>
        public string PancardNumber
        {
            set
            {
                if (value.Length == 10)
                    PancardNumber = value;
            }
            get
            {
                return PancardNumber;
            }
        }
    }
}
