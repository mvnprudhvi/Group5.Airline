using System;
using System.Xml.Schema;

namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// Represents Customer
    /// </summary>

    public class Customer
    {

        //private fields
        private int _customerid;
        private string _customeruserName;
        private string _customerEmail;
        private string _customerPassword;
        private string _customermobileNumber;
        private string _customeraadharNumber;
        private string _customerpancardNumber;
        private string _customerGender;


        /// <summary>
        /// constructors thst initializes deatails of customer
        /// </summary>
        public Customer()
        {

        }

        public Customer(int custid, string custusername, string custemail, string custpassword, string custmobileNumber, string custaadharNumber, string custpancardnumber, string custgender)
        {

            /// <param name="email"></param> email of customer
            /// <param name="password"></param> password of customer
            /// <param name="mobileNumber"></param> mobile number of customer
            /// <param name="aadharNumber"></param> aadhar number of customer
            /// <param name="pancardnumber"></param> pan card number of customer

            this._customerid = custid;
            this._customeruserName = custusername;
            this._customerEmail = custemail;
            this._customerPassword = custpassword;
            this._customermobileNumber = custmobileNumber;
            this._customeraadharNumber = custaadharNumber;
            this._customerpancardNumber = custpancardnumber;
            this._customerGender = custgender;
        }
        //represents customer id
        public int CustomerId
        {
            set
            {
                if (value >= 0 && value <= 9)
                {
                   CustomerId = value;
                }
            }
            get
            {
                return CustomerId;

            }
        }

        // represents customer username
        public string CustomerUserName
        {
            set
            {
                if (value.Length <= 20)
                    CustomerUserName = value;
            }
            get
            {
                return CustomerUserName;
            }
        }
        //represents customer email
        public string CustomerEmail
        {
            set
            {
                if (value.Length <= 20)
                {
                    CustomerEmail = value;
                }
                else
                {
                    throw new Exception("enter valid email Id:");
            }
        }
            get
            { 

               return CustomerEmail;
        }
    }
        // represents password of the customer 
        public string CustomerPassword
        {
            set
            {
                if (value.Length <= 10)
                    CustomerPassword = value;
            }
            get
            {
                return CustomerPassword;
            }
        }
        // represents number of the customer
        public string CustomerMobileNumber
        {
            set
            {
                //mobile number should contain 10 digits only
                if (value.Length == 10 && value[0] != 0)
                {
                    CustomerMobileNumber = value;
                }
                else
                {
                    throw new Exception("Mobile number should contain 10 digits only");
                }
            }
            get
            {
                return CustomerMobileNumber;
            }
        }

        // represents aadhar card number of customer
        public string CustomerAadharNumber
        {
            set
            {
                if (value.Length == 12)
                    CustomerAadharNumber = value;
            }
            get
            {
                return CustomerAadharNumber;
            }
        }
        // represents pan card number of customer
        public string CustomerPanCardNumber
        {
            set
            {
                if (value.Length == 10)
                    CustomerPanCardNumber = value;
            }
            get
            {
                return CustomerPanCardNumber;
            }
        }
        public string CustomerGender
        {
            set
            {
                if (value.Length == male && value.Length == female)
                {
                    CustomerGender = value;
                }
                else
                {
                    throw new Exception("Gender must be either male or female only");
                }
            }
            get
            {
                return CustomerGender;
            }
        }
    }
}
        
    
        