using Design_Patterns.Factory_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Design_Patterns
{
    internal class ContactsList
    {
     public List<Contact> contacts { get; set; } =new List<Contact>();
        public void Add(Contact contact)
        {
        contacts.Add(contact); 
        }
        public void AddContact(ContactPersonFactory contactFactory, string name, string phoneNumber,GroupEnum groups)
        {
            contacts.Add(contactFactory.CreatContactPerson(name, phoneNumber,groups));
        }
        public Contact? FindContactByName(string name)
        {
            return contacts.FirstOrDefault(c => c.Name == name);
        }
        public Contact? FindContactByPhonenumber(string phonenumber)
        {
            return contacts.FirstOrDefault(c => c.PhoneNumber == phonenumber);
        }


    }
}
