using Design_Patterns.Prototype_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal class SimContact: Contact ,IPrototype
    {
        public SimContact(string name, string phoneNumber) :base(name, phoneNumber, GroupEnum.GENERAL) {
            
        }
        public Dictionary<string, string> properties { get; set; } = new Dictionary<string, string>
        {
            { "email", null },
            { "dateOfBirth", null },
            { "sound", null },
            { "color", "DarkGray" }
        };
        public SimContact(SimContact simContact)
        {
            this.Name = simContact.Name;
            this.PhoneNumber = simContact.PhoneNumber;
            this.Groups = simContact.Groups;
            this.Properties = simContact.Properties;
        }
        public IPrototype Clone()
        {
            return new SimContact(this);
        }

    }
}
