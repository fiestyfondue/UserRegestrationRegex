﻿using System;

namespace REGEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("First letter should be capital.");
            Console.WriteLine("length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string firstname = Console.ReadLine();
            RegexValidation regex = new RegexValidation();
            regex.ValidateName(firstname);
            Console.WriteLine();
            Console.WriteLine("Enter Last name :");
            string lastname = Console.ReadLine();
            regex.ValidateName(lastname);
            Console.WriteLine();
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            regex.CheckEmail(email);
            Console.WriteLine();
            Console.WriteLine("Enter Phone Number :");
            string PhoneNo = Console.ReadLine();
            regex.PhoneNumber(PhoneNo);
            Console.WriteLine();
            Console.WriteLine("There needs to be a Number in the password");
            Console.WriteLine("Enter Password :");
            string Password = Console.ReadLine();
            regex.Password(Password);

        }
    }
}
