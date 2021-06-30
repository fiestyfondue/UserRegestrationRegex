using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class RegexValidation
    {
        string validateFirstName = "^[A-Z][a-z]{3,20}$";
        string validateEmail = "^[a-zA-Z0-9]+[._+-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        string validatePhoneNo = "^[0-9]{1,4}\\s[0-9]{10,12}$";
        string validatepassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
        public bool Name(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_NAME);
                if (Regex.IsMatch(name, validateFirstName))
                    return true;
                else
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_NAME);
            }
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool Email(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_EMAIL);
                if (Regex.IsMatch(email, validateEmail))
                    return true;
                else
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_EMAIL);
            }
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool PhoneNo(string phoneno)
        {

            try
            {
                if (string.IsNullOrEmpty(phoneno))
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_PHONE_NO);
                if (Regex.IsMatch(phoneno, validatePhoneNo))
                    return true;
                else
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_PHONE_NO);
            }
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public bool Password(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_PASSWORD);
                if (Regex.IsMatch(password, validatepassword))
                    return true;
                else
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_PASSWORD);
            }
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        //? is null conditional operator which is ==
        public bool lambdaExpNameValidation(string name) => Regex.IsMatch(name, validateFirstName) ? true : throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_NAME);
        public bool lambdaExpEmailValidation(string email) => Regex.IsMatch(email, validateEmail) ? true : throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_EMAIL);
        public bool lambdaExpPhoneNo(string phoneNo) => Regex.IsMatch(phoneNo, validatePhoneNo) ? true : throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_PHONE_NO);
        public bool lambdaExpPassword(string password) => Regex.IsMatch(password, validatepassword) ? true : throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_PASSWORD);

    }
}



