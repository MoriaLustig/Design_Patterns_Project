using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singltone_Folder
{
    internal class SingletonPrint
    {
        public ConsoleColor CurrentColoer = ConsoleColor.White;
        private static SingletonPrint printer;
        public static SingletonPrint Printer
        {
            get
            {
                if (printer == null)
                {
                    printer = new SingletonPrint();
                }
                return printer;
            }
        }
        private SingletonPrint()
        {
            Console.WriteLine("Create");
        }
        public void Print(Contact contact,string title) {
            Console.WriteLine(title);
            Console.WriteLine("####################################");
            if (contact.Properties["Color"] != null)
            {
                if (contact.Properties["Color"].CompareTo("White") != 0)
                {
                    CurrentColoer = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), contact.Properties["Color"]);
                    Console.ForegroundColor = CurrentColoer;
                }
            }
            Console.WriteLine(contact.ToString());
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
