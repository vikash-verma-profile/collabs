namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;


    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(int contactId, string name, int age, string gender, string phoneNumber, string email)
        {
            if (age <= 18)
            {
                throw new InvalidAgeException("Age must be greater than 18.");
            }

            ContactId = contactId;
            Name = name;
            Age = age;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void DisplayContactDetails()
        {
            Console.WriteLine($"Contact ID: {ContactId}, Name: {Name}, Age: {Age}, Gender: {Gender}, Phone Number: {PhoneNumber}, Email: {Email}");
        }
    }


    public class ContactManager
    {
        public List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            foreach (var c in contacts)
            {
                if (c.ContactId == contact.ContactId)
                {
                    Console.WriteLine($"A contact with ID {contact.ContactId} already exists.");
                    return;
                }
            }

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            Console.WriteLine("Contact List:");
            foreach (var contact in contacts)
            {
                contact.DisplayContactDetails();
            }
        }
    }


    public class Program
    {
        public static void Main1(string[] args)
        {
            ContactManager manager = new ContactManager();

            bool running = true;

            while (running)
            {
                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            int id = int.Parse(Console.ReadLine());
                            string name = Console.ReadLine();
                            int age = int.Parse(Console.ReadLine());
                            string gender = Console.ReadLine();
                            string phone = Console.ReadLine();
                            string email = Console.ReadLine();

                            Contact contact = new Contact(id, name, age, gender, phone, email);
                            manager.AddContact(contact);
                            break;

                        case 2:
                            manager.DisplayContacts();
                            break;

                        case 3:
                            Console.WriteLine("Exiting program...");
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }
                catch (InvalidAgeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid details.");
                    Console.WriteLine("Exiting program...");
                    break;
                }
            }
        }
    }

}