using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Folder
{
    internal class SimContactFactory: ContactPersonFactory
    {
        public override Contact CreatContactPerson(string name, string phoneNumber, GroupEnum group)
        {
            return new SimContact(name, phoneNumber);
        }
    }
}
