namespace basics_of_c_sharp.DesignPatterns.SingletonPattern;

public class SingletonTestDrive
{
    public static void Main()
    {
        Person person = Person.Instance;
        person.Name = "John";

        Person person2 = Person.Instance;
        person2.Name = "John 2";

        Console.WriteLine($"Name: {person.Name}"); // john2
        Console.WriteLine($"Name: {person2.Name}"); // john2
    }
}
