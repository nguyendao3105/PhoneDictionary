﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace SPhoneDic
{
    public class Customer
    {
        public string   Name { get; set; }
        public string Address { get; set; }
        public string  Email { get; set; }
        public string  PhoneNumber { get; set; }

        public Customer(string name, string address, string email, string phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
