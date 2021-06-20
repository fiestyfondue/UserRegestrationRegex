using System;

namespace REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string name = Console.ReadLine();
            RegexValidation regex = new RegexValidation();
            bool validName = regex.ValidateFirstName();
            Console.WriteLine(validName);
        }
    }
}
