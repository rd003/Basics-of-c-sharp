namespace BasicsOfCsharp;
public class Program
{
    public static Dictionary<string, int> contacts = new Dictionary<string, int>();
    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine(@"
     1. Add New Contact
     2. Display All
     3. Update Contact
     4. Remove Contact
     5. Search Contact
     6. Exit
    ");
            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    DisplayAll();
                    break;
                case "3":
                    Update();
                    break;
                case "4":
                    Remove();
                    break;
                case "5":
                    Search();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice.");
                    break;
            }
        }

        void Add()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter contact: ");
            int contact = int.Parse(Console.ReadLine());
            contacts.Add(name, contact);
            Console.WriteLine("Contact has added");
        }

        void Update()
        {
            Console.Write("Enter name whose contact you want to update:  ");
            string name = Console.ReadLine();
            Console.Write("Enter new contact :");
            int newContact = int.Parse(Console.ReadLine());
            if (contacts.ContainsKey(name))
            {
                contacts[name] = newContact;
                Console.WriteLine("Contact has updated");

            }
            else
            {
                Console.WriteLine("Contact does not found");
            }
        }

        void Remove()
        {
            Console.Write("Enter name whose contact you want to delete:  ");
            string name = Console.ReadLine();
            if (contacts.ContainsKey(name))
            {
                contacts.Remove(name);
                Console.WriteLine("Contact has deleted.");

            }
            else
            {
                Console.WriteLine("Contact does not found");
            }
        }

        void Search()
        {
            Console.Write("Enter name whose contact you want to search:  ");
            string name = Console.ReadLine();
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"name: {name}, contact: {contacts[name]}");

            }
            else
            {
                Console.WriteLine("Contact does not found");
            }
        }

        void DisplayAll()
        {
            Console.WriteLine("all contacts: ");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Key}, Contact: {contact.Value}");
            }
        }
    }
}