namespace BasicsOfCSharp.DictionaryUseCases;
public class Mapping
{
    public static void ExecuteMethod()
    {
        Dictionary<int, string> people = new();
        people.Add(1, "John");
        people.Add(2, "Jack");
        people.Add(3, "Ravindra");

        // find the person with id
        int id = 2;
        if (people.TryGetValue(id, out string person))
        {
            Console.WriteLine($"Person with id : {id} is {person}");
        }
        else
        {
            Console.WriteLine($"Person with id: {id} does not exists.");
        }
        Console.ReadLine();
    }
}