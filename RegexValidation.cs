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
    }

}

