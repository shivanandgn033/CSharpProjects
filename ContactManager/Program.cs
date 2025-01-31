using System;
using System.Collections.Generic;

class ContactManager
{
    class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
        string option;
        do
        {
            Console.WriteLine("\nContact Management System");
            Console.WriteLine("Add 1st contact");
            Console.WriteLine("2. Show contacts");
            Console.WriteLine("3. Edit contact");
            Console.WriteLine("4. Delete contact");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": AddContact(); break;
                case "2": DisplayContacts(); break;
                case "3": EditContact(); break;
                case "4": DeleteContact(); break;
            }
        } while (option != "5");
    }

    static void AddContact()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Telephone: ");
        string phone = Console.ReadLine();

        contacts.Add(new Contact { Name = name, Email = email, Phone = phone });
        Console.WriteLine("Contact added.");
    }

    static void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        Console.WriteLine("\nContact:");
        for (int i = 0; i < contacts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {contacts[i].Name} - {contacts[i].Email} - {contacts[i].Phone}");
        }
    }

    static void EditContact()
    {
        DisplayContacts();
        Console.Write("Contact number to edit: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < contacts.Count)
        {
            Console.Write("New Name (leave blank to leave unchanged): ");
            string name = Console.ReadLine();
            Console.Write("New Email (leave blank to leave unchanged): ");
            string email = Console.ReadLine();
            Console.Write("New Telephone (leave blank to leave unchanged): ");
            string phone = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name)) contacts[index].Name = name;
            if (!string.IsNullOrWhiteSpace(email)) contacts[index].Email = email;
            if (!string.IsNullOrWhiteSpace(phone)) contacts[index].Phone = phone;

            Console.WriteLine("Contact updated.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    static void DeleteContact()
    {
        DisplayContacts();
        Console.Write("Contact number to delete: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < contacts.Count)
        {
            contacts.RemoveAt(index);
            Console.WriteLine("Contact deleted.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}