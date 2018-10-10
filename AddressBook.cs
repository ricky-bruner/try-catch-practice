using System.Collections.Generic;

namespace tryCatch_practice
{
    public class AddressBook
    {
        Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            addressBook.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            return addressBook[email];
        }
    }
}