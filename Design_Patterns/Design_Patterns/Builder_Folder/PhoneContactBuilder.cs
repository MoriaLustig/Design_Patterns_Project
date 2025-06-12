using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Folder
{
    internal class PhoneContactBuilder : ContactBuilder
    {
        public PhoneContact phoneContact;
        public void Reset(string name, string phoneNumber)
        {
            phoneContact = new PhoneContact(name, phoneNumber);
        }
        public void AddColor(string color)
        {
            phoneContact.Properties["color"] = color;
        }

        public void AddDateOfBirth(string birthday)
        {
            phoneContact.Properties["BirthDate"] = birthday;
        }

        public void AddEmail(string email)
        {
            phoneContact.Properties["email"] = email;
        }

        public void AddSound(string sound)
        {
            phoneContact.Properties["Sound"] = sound;
        }
        public void AddGroup(GroupEnum group)
        {
            phoneContact.Groups = group;
        }
        public void Save()
        {
            Console.WriteLine("The contact is saved on the phone"); 
        }
        public Contact ret()
        {

            return phoneContact;

        }
    }
}
