using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder_Folder
{
    internal class ContactDirector
    {
        ContactBuilder builder;
        public ContactDirector(ContactBuilder _builder)
        {
            builder = _builder;
        }
        public void ChangeBuilder(ContactBuilder _builder)
        {
            builder = _builder;
        }
        public void BasicContact(string name,string phoneNumber)
        {
            builder.Reset(name,phoneNumber);
            builder.AddSound("SHUVI NAFSHI...");
            builder.AddDateOfBirth("01/01/25");
            builder.AddGroup(GroupEnum.GENERAL);
            builder.Save();
        }
        public void CustomizedContact1(string name, string phonrNumber, string dateOfBirth, string email)
        {
            builder.Reset(name, phonrNumber);
            builder.AddEmail(email);
            builder.AddDateOfBirth(dateOfBirth);
            builder.Save();

        }
        public void CustomizedContact2(string name, string phoneNumber, string sound, string color)
        {
            builder.Reset(name, phoneNumber);
            builder.AddColor(color);    
            builder.AddSound(sound);
            builder.Save();

        }
    }
}
