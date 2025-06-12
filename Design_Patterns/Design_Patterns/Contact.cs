using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public GroupEnum Groups { get; set; }
        public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>(){
        { "BirthDate", "" },
        {"email", "" },
        { "Sound", "" },
        {"Color",""}
        };
        public Contact(string name, string phoneNumber, GroupEnum groups)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Groups = groups;

        }
        public Contact()
        {
                
        }
        public Contact(string name,string phoneNumber)
        {
        Name = name;
        PhoneNumber = phoneNumber;
        }
       
      
        public string ToString()
        {
            string s = $"{"Name",-15}: {Name,-15} \n";
            s += $"{"PhoneNumber",-15}: {PhoneNumber,-15} \n";
            s += $"{"Group",-15}: {Groups,-15} \n";
            foreach (var item in Properties)
            {
                s += $"{item.Key,-15}: {item.Value,-15}\n";
            }
            return s;
        }
    }
}
