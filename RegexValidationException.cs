using System;
using System.Collections.Generic;
using System.Text;

namespace REGEX
{
    public class RegexValidationException : Exception
    {
        public enum InvalidUserDetails
        {
            EMPTY_NAME,
            EMPTY_EMAIL,
            EMPTY_PHONE_NO,
            EMPTY_PASSWORD,
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_PHONE_NO,
            INVALID_PASSWORD
        }
        // Custom Exceptions for User Validations, returns the message to Console.
        public RegexValidationException(InvalidUserDetails error)
        {
            if(error == InvalidUserDetails.EMPTY_NAME)
                Console.WriteLine(error+"Name can't be empty or null");
            if(error == InvalidUserDetails.EMPTY_EMAIL)
                Console.WriteLine(error+"Email cannot be empty");
            if(error == InvalidUserDetails.EMPTY_PHONE_NO)
                Console.WriteLine(error+"Phone number cannot be empty");
            if(error == InvalidUserDetails.INVALID_PASSWORD)
                Console.WriteLine(error+"Password cannot be empty");
            if(error == InvalidUserDetails.INVALID_NAME)
                Console.WriteLine(error+"Name Not validated");
            if(error==InvalidUserDetails.INVALID_EMAIL)
                Console.WriteLine(error+"Email not validated");
            if(error==InvalidUserDetails.INVALID_PHONE_NO)
                Console.WriteLine(error+"Phone number not validated");
            if(error==InvalidUserDetails.INVALID_PASSWORD)
                Console.WriteLine(error+"Password not validated");
        }
    }
}
