using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype_Folder
{
    internal class PrototypeRegistry
    {
         List<IPrototype> Prototypes = new List<IPrototype>();
            public PrototypeRegistry()
            {
                Prototypes.Add(new PhoneContact(GroupEnum.FAMILY)
                {
                    Properties = {
                    ["sound"]="ttttttttt",
                    ["color"]="Red",
                    ["dateOfBirth"]="0-0-0",
                }
                });

                Prototypes.Add(new PhoneContact(GroupEnum.FRIENDS)
                {
                    Properties = {
                    ["sound"]="nnnnnnnnnnnn",
                    ["color"]="Blue",
                    ["dateOfBirth"]="0-0-0",
                }
                });

                Prototypes.Add(new PhoneContact(GroupEnum.WORK)
                {
                    Properties = {
                    ["sound"]="mmmmmmmmmmm",
                    ["color"]="Yellow",
                    ["email"]="moria.lustig@gmail.com",
                }
                });

        }

            public IPrototype GetContantPerson(GroupEnum g)
            {
                return Prototypes.First(x => ((PhoneContact)x).Groups == g)?.Clone();
            }
        }
    }

