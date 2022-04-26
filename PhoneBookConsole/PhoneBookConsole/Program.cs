// See https://aka.ms/new-console-template for more information
using PhoneBookConsole;

Console.WriteLine("> Hello from the Console PhoneBook app!");
Console.WriteLine("> Select operation:");
Console.WriteLine("> 1. Add contact");
Console.WriteLine("> 2. Display contact by number");
Console.WriteLine("> 3. View all contacts");
Console.WriteLine("> 4. Search for contacts by a given name");
Console.WriteLine("> To quit; x/q/exit/quit");

var userInput = Console.ReadLine();

var phoneBook = new PhoneBook();

while (true)
{
    switch (userInput)
    {
        case "1":
            Console.WriteLine("> Contact name:");
            var name = Console.ReadLine();
            Console.WriteLine("> Contact number:");
            var number = Console.ReadLine();

            var newContact = new Contact(name, number);
            phoneBook.AddContact(newContact);
            break;

        case "2":
            Console.WriteLine("> Contact number:");
            var searchNumber = Console.ReadLine();
            phoneBook.DisplayContact(searchNumber);
            break;

        case "3":
            Console.WriteLine("> All contacts:");
            phoneBook.DisplayAllContacts();
            break;

        case "4":
            Console.WriteLine("> Search for name:");
            var searchPhrase = Console.ReadLine();
            phoneBook.DisplayMatchingContact(searchPhrase);
            break;

        case "x":
        case "q":
        case "exit":
        case "quit":
            return;

        default:
            Console.WriteLine("> Invalid opperation");
            break;
    }

    Console.WriteLine(">");
    Console.WriteLine("> Select operation:");
    userInput = Console.ReadLine();
}

