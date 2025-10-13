using System;
using System.Collections.Generic;

// Class to represent each contact
class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    // Constructor
    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }

    // Method to display contact details
    public void DisplayContact()
    {
        Console.WriteLine($"Name: {Name}, Phone: {PhoneNumber}");
    }
}

// ContactManager class to handle multiple contacts
class ContactManager
{
    private List<Contact> contacts = new List<Contact>();

    // Method to add a new contact
    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
        Console.WriteLine($"{contact.Name} added successfully!");
    }

    // Method to remove a contact by name
    public void RemoveContact(string name)
    {
        Contact contactToRemove = contacts.Find(c => c.Name == name);
        if (contactToRemove != null)
        {
            contacts.Remove(contactToRemove);
            Console.WriteLine($"{name} removed successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }

    // Method to search a contact by name
    public void SearchByName(string name)
    {
        Contact foundContact = contacts.Find(c => c.Name == name);
        if (foundContact != null)
        {
            Console.WriteLine("Contact Found:");
            foundContact.DisplayContact();
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }

    // Optional: Display all contacts
    public void DisplayAll()
    {
        Console.WriteLine("\n Contact List ");
        foreach (var contact in contacts)
        {
            contact.DisplayContact();
        }
    }
}

// Main Program
class Program
{
    static void Main()
    {
        ContactManager manager = new ContactManager();

        // Adding contacts
        manager.AddContact(new Contact("Sujit", "9801111111"));
        manager.AddContact(new Contact("Sushan", "9812222222"));
        manager.AddContact(new Contact("Ajit", "9823333333"));

        // Display all contacts
        manager.DisplayAll();

        // Searching for a contact
        Console.WriteLine("\nSearching for Sushan:");
        manager.SearchByName("Sushan");

        // Removing a contact
        Console.WriteLine("\nRemoving Ajit:");
        manager.RemoveContact("Ajit");

        // Display updated contact list
        manager.DisplayAll();
    }
}
