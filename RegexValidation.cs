using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    class RegexValidation
    {
        public void ValidateName(string name)
        {
            string validateFirstName = "^[A-Z][a-z]{3,}$";
            try
            {
                if (Regex.IsMatch(name, validateFirstName))
                    Console.WriteLine(" Name saved succesfull");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CheckEmail(string email)
        {
            string validateEmail = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}$";
            try
            {
                if(Regex.IsMatch(email,validateEmail))
                    Console.WriteLine("Email saved successfully");
                else
                    Console.WriteLine("Invalid Email");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void PhoneNumber(string phoneNo)
        {
            string validatePhoneNo = "^[0-9]{10}$";
            try
            {
                if(Regex.IsMatch(phoneNo,validatePhoneNo))
                    Console.WriteLine("Phone number saved successfully");
                else
                    Console.WriteLine("Invalid PhoneNumber");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}



