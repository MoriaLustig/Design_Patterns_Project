using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Folder
{
    internal interface ContactBuilder
    {
        void AddColor(string color);
        void AddDateOfBirth(string birthday);
        void AddEmail(string email);
        void AddSound(string sound);
        void AddGroup(GroupEnum group);
        public void Save();
        void Reset(string _name, string _phoneNumber);
    }
}
