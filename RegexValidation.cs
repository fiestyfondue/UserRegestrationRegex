using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEX
{
    public class RegexValidation
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{6,}$";
        

        public bool ValidateFirstName()
        {
            return Regex.IsMatch("Harshsinha", NAME_REGEX);
        }
        
    }
}
