﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegexValidation
    {    
        // Method to validate last name
        public static void FirstName()
        {
            string regex = "[A-Z]{1}[a-z]{3,10}$";
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(fName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        // Method to validate last name
        public static void LastName()
        {
            string regex = "[A-Z]{1}[a-z]{3,10}$";
            Console.WriteLine("Enter Last name");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(fName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }

        // Method to validate  EmailId
        public static void Email()
        {
            string regex = "[a-zA-Z0-9_.]+@[a-zA-Z.]+$";
            Console.WriteLine("Enter EmailId");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(fName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
