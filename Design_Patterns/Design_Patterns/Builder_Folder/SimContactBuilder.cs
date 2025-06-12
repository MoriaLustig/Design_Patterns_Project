using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Folder
{
    internal class SimContactBuilder:ContactBuilder
    {
        public SimContact simContact;
        public void Reset(string name, string phoneNumber)
        {
            simContact = new SimContact(name, phoneNumber);
        }
        public void AddColor(string color)
        {
            simContact.Properties["color"] = color;
        }

        public void AddDateOfBirth(string birthday)
        {
            simContact.Properties["BirthDate"] = birthday;
        }

        public void AddEmail(string email)
        {
            simContact.Properties["email"] = email;
        }

        public void AddSound(string sound)
        {
            simContact.Properties["Sound"] = sound;
        }
        public void AddGroup(GroupEnum group)
        {
            if (group != GroupEnum.GENERAL)
                Console.WriteLine("you can't insert this group");
            simContact.Groups = GroupEnum.GENERAL;
        }
        public void Save()
        {
            Console.WriteLine("The contact is saved on the Sim"); 
        }
        public Contact ret() {

            return simContact;

        }
    }
}
