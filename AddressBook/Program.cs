// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.Write("Select Number:\n1)AddContacts\n2)EditContact\n3)DeleteContact\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new CreateNewContact().Show();
        break;


        EditEntry.NewContact();
        EditEntry.ListAllContact();
        EditEntry.Update();
       
    case 3:
        DeleteContact.NewContact();
        DeleteContact.ListAllContacts();
        DeleteContact.Delete();
        break;

        break;
    default:
        Console.Write("Please Select Correct Number");
        break;

}
