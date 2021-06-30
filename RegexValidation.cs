using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class RegexValidation
    {
        public void Name(string name)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if(Regex.IsMatch(name,validateFirstName))
                {
                    Console.WriteLine("Name validated successfully");
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Email(string email)
        {
            string validateEmail= "^[a-zA-Z0-9]+[._+-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            try
            {
                if(Regex.IsMatch(email,validateEmail))
                {
                    Console.WriteLine("Email Validated Successfully");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
            catch(Exception EMAIL)
            {
                Console.WriteLine(EMAIL.Message);
            }
        }
        public void PhoneNo(string phoneno)
        {
            string validatePhoneNo= "^[0-9]{1,4}\\s[0-9]{10,12}$";
            try
            {
                if(Regex.IsMatch(phoneno,validatePhoneNo))
                {
                    Console.WriteLine("Phone number validated successfully");
                }
                else
                {
                    Console.WriteLine("Invalid Phone number ");
                }
            }
            catch(Exception PHONENO)
            {
                Console.WriteLine(PHONENO.Message);
            }
        }
        public void Password(string password)
        {
            string validatePassword= "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
            try
            {
                if(Regex.IsMatch(password, validatePassword))
                {
                    Console.WriteLine("Password Validated successfully");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }
            catch(Exception PASSWORD)
            {
                Console.WriteLine(PASSWORD.Message);
            }
        }
                    ////public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{6,}$";
        ////public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        ////public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([a-zA-Z]{2,3}){0,1}";
        ////public static string PASSWORD_REGEX = "^[a-zA-Z0-9]{8,}";    //8,-> means 8 or more

        //public bool ValidateFirstName(string name)
        //{
            
        //    return Regex.IsMatch(name, NAME_REGEX);
        //}
        //public bool ValidMobileNumber()
        //{
        //    return Regex.IsMatch("6123455663", MOBILENUMBER_REGEX);
        //}
        //public bool ValidEmail()
        //{
        //    return Regex.IsMatch("mmkr7111.09asd@gmail.com", EMAIL_REGEX);
        //}
        //public bool ValidPassword()
        //{
        //    return Regex.IsMatch("Password44", PASSWORD_REGEX);
        //}



    }
}



