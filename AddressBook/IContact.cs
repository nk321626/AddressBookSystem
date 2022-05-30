using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public interface IContact
    {
        void AddContactDetails(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailId, string bookName);
        void ViewContact(string bookName);
        void ViewContact(string personName, string bookName);
        void EditContact(string personName, string bookName);
        void DeleteContact(string personName, string bookName);
        void AddAddressBook(string bookName);
        void CheckAddressBook(string bookName);
    }
}
