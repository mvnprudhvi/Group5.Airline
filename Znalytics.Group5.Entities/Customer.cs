
using System;
using System.Collections.Generic; 
using System.Text.RegularExpressions;

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
                Regex r = new Regex(@"^[a - zA - Z0 - 9] + ([._]?[a - zA - Z0 - 9] +) *$");
                if (r.IsMatch(value)==true)
                {
                    CustomerUserName = value;
                }
                else
                {
                    throw new Exception("user name must contain alpha numeric characters,underscore and dot:");
                }
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
                Regex r = new Regex("^[a-zA-Z0-9@.]*$");

                if (r.IsMatch(value)== true)
                {
                    CustomerEmail = value;
                }
                else
                {
                    throw new Exception("email Id must not contain spaces and should have @ symbol");
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
                Regex r = new Regex(@"^(?=.*\d)(?=.*[a - z])(?=.*[A - Z]).{ 4,8}$");
                if (r.IsMatch(value) == true)
                {
                    CustomerPassword = value;
                }

                else
                {
                    throw new Exception("Password must be atleast 4-8 characters and must contain 1 upper case,1 lower case,1 number");
                }
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
                Regex r = new Regex(@"^((\+)?(\d{2}[-]))?(\d{10}){1}?$");

            if (r.IsMatch(value) == true)
            {
                CustomerMobileNumber = value;
            }
            else
                    {
                        throw new Exception("Mobile number must only contain 10 digits");
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
                Regex r = new Regex(@"^\d{4}\s\d{4}\s\d{4}$");
                if (r.IsMatch(value) == true)
                {
                    CustomerAadharNumber = value;
                }
                else
                {
                    throw new Exception("Aadhar card number must be in 1111 1111 1111 1111 format only");
                }
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
                Regex r = new Regex(@"[A-Z]{5}[0-9]{4}[A-Z]{1}");
                if (r.IsMatch(value) == true)
                {
                    CustomerPanCardNumber = value;
                }
                else
                {
                    throw new Exception("Pan card number must contin only 9 characters");
                }
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
                Regex r = new Regex(@"^(?:m|M|male|Male|f|F|female|Female)$");
                if (r.IsMatch(value)== true)
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
        
    
        