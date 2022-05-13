using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        // variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int PostalCode;
        public long phoneNumber;

        public string emailId;
        private long postalCode;
        private string email;

        public Contact(string firstName, string lastName, string address, string city, string state, int PostalCode, long phoneNumber, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.PostalCode = PostalCode;
            this.phoneNumber = phoneNumber;
            this.emailId = emailId;
        }

        public Contact(string firstName, string lastName, string address, string city, string state, long postalCode, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.postalCode = postalCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        /// <summary>
        /// To display the contact details.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("First Name:{0}", this.firstName);
            Console.WriteLine("Last Name:{0}", this.lastName);
            Console.WriteLine("Address:{0}", this.address);
            Console.WriteLine("City: {0}", this.city);
            Console.WriteLine("State:{0}", this.state);
            Console.WriteLine("Postalcode:{0}", this.PostalCode);
            Console.WriteLine("phone number:{0}", this.phoneNumber);
            Console.WriteLine("EmailId:{0}", this.emailId);

        }
    }
}