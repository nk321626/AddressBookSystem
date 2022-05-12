﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
     public class Contact
     {
        // get method-return the value of the variable.
        // get method-assigns a value to the variable.
        public string FirstName { get; set; }    
        public string LastName { get; set; } 
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }


    }
}
