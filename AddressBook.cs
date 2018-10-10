using System;
using System.Collections.Generic;

namespace tryCatch_practice
{
    public class AddressBook
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            try
            {
                addressBook.Add(contact.Email, contact);
            } catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Contact GetByEmail(string email)
        {
            return addressBook[email];
        }
    }
}