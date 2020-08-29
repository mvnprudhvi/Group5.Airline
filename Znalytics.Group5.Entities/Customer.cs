
using System;
using System.Collections.Generic; 
using System.Text.RegularExpressions;

namespace Znalytics.Group5.Airline.Entities
{
    /// <summary>
    /// Class That Represents Customer Module in Online Airline Reservation System Project
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
        /// Constructor That Initializes Fields
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>  
        /// <param name="email"></param>  
        /// <param name="password"></param>  
        /// <param name="mobileNumber"></param>  
        /// <param name="aadharNumber"></param>  
        /// <param name="pancardnumber"></param>
        /// <param name="gender"></param>  
        public Customer(int custid, string custusername, string custemail, string custpassword, string custmobileNumber, string custaadharNumber, string custpancardnumber, string custgender)
        {
             _customerid = custid;
             _customeruserName = custusername;
             _customerEmail = custemail;
             _customerPassword = custpassword;
             _customermobileNumber = custmobileNumber;
             _customeraadharNumber = custaadharNumber;
             _customerpancardNumber = custpancardnumber;
             _customerGender = custgender;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Customer()
        {

        }

        // Property for setting values to CustomerId field and Getting The value of the Field
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

        // Property for setting values to Customer UserName field and Getting The value of the Field
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

        // Property for setting values to Customer Email field and Getting The value of the Field
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

        // Property for setting values to Customer Password field and Getting The value of the Field
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


        // Property for setting values to Customer Mobile Number field and Getting The value of the Field
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


        //  Property for setting values to Customer Aadhar Number field and Getting The value of the Field
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

        //  Property for setting values to Customer Pan Card Number field and Getting The value of the Field
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

        //Property for setting values to Customer Gender field and Getting The value of the Field
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
        
    
        