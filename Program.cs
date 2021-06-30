using System;

namespace REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string firstname = Console.ReadLine();
            regex.Name(firstname);
            Console.WriteLine("Enter Last name :");
            string lastname = Console.ReadLine();
            regex.Name(lastname);
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            regex.Email(email);
            Console.WriteLine("Enter Phone no. :");
            string mobile = Console.ReadLine();
            regex.PhoneNo(mobile);
            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();
            regex.Password(password);


        }
    }
}
