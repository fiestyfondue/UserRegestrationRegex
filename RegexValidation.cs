using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class RegexValidation
    {
        public bool Name(string name)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if (Regex.IsMatch(name, validateFirstName))
                    return true;

                else
                    return false;
                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool Email(string email)
        {
            string validateEmail= "^[a-zA-Z0-9]+[._+-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            try
            {
                if (Regex.IsMatch(email, validateEmail))
                    return true;
                //{
                //    Console.WriteLine("Email Validated Successfully");
                //}
                else
                    return false;
                //{
                //    Console.WriteLine("Invalid Email");
                //}
            }
            catch(Exception EMAIL)
            {
                Console.WriteLine(EMAIL.Message);
            }
            return false;
        }
        public bool PhoneNo(string phoneno)
        {
            string validatePhoneNo= "^[0-9]{1,4}\\s[0-9]{10,12}$";
            try
            {
                if (Regex.IsMatch(phoneno, validatePhoneNo))
                    return true;
                //{
                //    Console.WriteLine("Phone number validated successfully");
                //}
                else
                    return false;
                //{
                //    Console.WriteLine("Invalid Phone number ");
                //}
            }
            catch(Exception PHONENO)
            {
                Console.WriteLine(PHONENO.Message);
            }
            return false;
        }
        public bool Password(string password)
        {
            string validatePassword= "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
            try
            {
                if (Regex.IsMatch(password, validatePassword))
                    return true;
                //{
                //    Console.WriteLine("Password Validated successfully");
                //}
                else
                    return false;
                //{
                //    Console.WriteLine("Invalid Password");
                //}
            }
            catch(Exception PASSWORD)
            {
                Console.WriteLine(PASSWORD.Message);
            }
            return false;
        }
              
    }
}



