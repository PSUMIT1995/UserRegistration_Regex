﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegexValidation.FirstName();
            RegexValidation.LastName();
            RegexValidation.Email();
            RegexValidation.MobileNumber();
            RegexValidation.Password();
        }
    }
}