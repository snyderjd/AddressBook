using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts { get; set; }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            return Contacts[email];
        }
    }
}