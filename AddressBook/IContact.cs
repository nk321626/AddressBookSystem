﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public interface IContact
    {
        void AddContactDetails(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailId);
        void ViewContact();
        void ViewContact(string personName);
        void EditContact(string personName);
        void DeleteContact(string personName);
    }
}
