
namespace SampleProject
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message):base(message) { }
    }
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Contact(int contactId,string name,int age,string gender,string phoneNumber,string email)
        {
            if(age <= 18)
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
            Console.WriteLine("Contact ID: {ContactId}, Name: {Name}, Age: {Age}, Gender: {Gender}, Phone Number: {PhoneNumber}, Email: {Email}");
        }
    }
    public class ContactManager
    {
        public List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            foreach (var item in contacts)
            {
                if(item.ContactId==contact.ContactId)
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
            Console.WriteLine("Contact List:");
            if(contacts.Count>0)
            {
                foreach (var item in contacts)
                {
                    Console.WriteLine($"Contact ID: {item.ContactId}, Name: {item.Name}, Age: {item.Age}, Gender: {item.Gender}, Phone Number: {item.PhoneNumber}, Email: {item.Email}");
                }

            }
            else
            {
                Console.WriteLine("No contacts available.");
            }
           
        }

    }
    internal class Class11
    {
        public static void Main()
        {
          
            ContactManager manager = new ContactManager();
            try
            {
                bool flag = true;
                while (flag)
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            int ContactId = int.Parse(Console.ReadLine());
                            string Name = Console.ReadLine();
                            int Age = int.Parse(Console.ReadLine());
                            string Gender = Console.ReadLine();
                            string PhoneNumber = Console.ReadLine();
                            string Email = Console.ReadLine();
                            Contact c = new Contact(ContactId, Name, Age, Gender, PhoneNumber, Email);
                            manager.AddContact(c);
                            break;
                        case 2:
                            manager.DisplayContacts();
                            break;
                        case 3:
                            Console.WriteLine("Exiting program...");
                            flag = false;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
