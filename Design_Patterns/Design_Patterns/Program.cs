using Design_Patterns.Builder_Folder;
using Design_Patterns.Factory_Folder;
using Design_Patterns.Prototype_Folder;
using Design_Patterns.Singltone_Folder;
using Design_Patterns;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

ContactsList contactsList = new ContactsList();
PhoneContactFactory phoneContactFactory = new PhoneContactFactory();
contactsList.AddContact(phoneContactFactory, "Moria", "0583231590", GroupEnum.FRIENDS);

SimContactFactory simContactFactory = new SimContactFactory();
contactsList.AddContact(simContactFactory, "Esther", "0548548842", GroupEnum.WORK);

SimContactBuilder simContactBuilder = new SimContactBuilder();
ContactDirector contactDirector=new ContactDirector(simContactBuilder);
contactDirector.BasicContact("Rina", "02-6241590");
contactsList.Add(simContactBuilder.ret());
PhoneContactBuilder phoneContactBuilder = new PhoneContactBuilder();
contactDirector.ChangeBuilder(phoneContactBuilder);
contactDirector.CustomizedContact1("Hadassa", "0586742456", "01/03/23", "fgsgs@gmail.com");
contactsList.Add(phoneContactBuilder.ret());



//PhoneContactBuilder phoneContactBuilder2 = new PhoneContactBuilder();
//phoneContactBuilder2.Reset("Sara", "0527617931", GroupEnum.WORK);
//phoneContactBuilder2.AddColor("Green");
//phoneContactBuilder2.AddRingtone("li-la-li-la");
//phoneContactBuilder2.AddBirthday("02-05-1995");
//contactsList.AddContactPerson(phoneContactBuilder2.GetResult());
//SingletonPrint.Printer.Print(phoneContactBuilder2.GetResult(), "From Program");

//PrototypeRegistry prototypeRegistry = new PrototypeRegistry();
//PhoneContact phoneContact = (PhoneContact)prototypeRegistry.GetContantPerson(GroupEnum.FAMILY);
