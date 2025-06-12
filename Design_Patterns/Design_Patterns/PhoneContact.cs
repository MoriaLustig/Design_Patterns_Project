using Design_Patterns.Prototype_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal class PhoneContact: Contact, IPrototype
    {
        public PhoneContact(string name, string phoneNumber, GroupEnum groups) : base(name, phoneNumber, groups)
        { }
        public Dictionary<string, string> properties { get; set; } = new Dictionary<string, string>
        {
            { "email", null },
            { "dateOfBirth", null },
            { "sound", null },
            { "color", null }
        };
        public PhoneContact(string name, string phoneNumber) : base(name, phoneNumber) { }
        public PhoneContact(PhoneContact phoneContact)
        {
            this.Name = phoneContact.Name;
            this.PhoneNumber = phoneContact.PhoneNumber;
            this.Groups = phoneContact.Groups;
            this.Properties= phoneContact.Properties;
        }
        public PhoneContact(GroupEnum group)
        {
            this.Groups = group;
        }
        public void Addcolor(string color)
       {
                Properties[color] = color;
       }

        public IPrototype Clone()
        {
            return new PhoneContact(this);
        }
    }
}
