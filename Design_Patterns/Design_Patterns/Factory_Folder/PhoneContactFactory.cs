using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Folder
{
    internal class PhoneContactFactory : ContactPersonFactory
    {
        public override Contact CreatContactPerson(string name, string phoneNumber, GroupEnum groups)
        {
           return new Contact(name, phoneNumber, groups);
        }

    }
}
