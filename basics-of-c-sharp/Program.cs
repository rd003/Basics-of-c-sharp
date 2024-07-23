// using BasicsOfCSharp.LINQ;

// Query9.Execute();

//https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/walkthrough-writing-queries-linq#use-method-syntax-in-a-query-expression

using BasicsOfCSharp.Polymorphism;

public class PetshopEntrySimulator
{
    static void Main()
    {
        Animal cat1 = new Cat("Whiskers", "Persian", "White");
        Animal cat2 = new Cat("Mittens", "Maine Coon", "Grey/Tabby");
        Animal cat3 = new Cat("Ginger", "British Shorthair", "Orange/Ginger");

        Dog dog1 = new Dog("Max", "Golden Retriever", "Golden");
        Dog dog2 = new Dog("Luna", "Sibarian Husky", "Grey/White");
        Dog dog3 = new Dog("Duke", "Labrador Retriever", "Chocolate Brown");

        PetShopEntrySystem entrySystem = new PetShopEntrySystem();

        // adding cats
        entrySystem.AddAnimal(cat1);
        entrySystem.AddAnimal(cat2);
        entrySystem.AddAnimal(cat3);

        // adding dogs
        entrySystem.AddAnimal(dog1);
        entrySystem.AddAnimal(dog2);
        entrySystem.AddAnimal(dog3);

        var animals = entrySystem.GetAnimals();
        DisplayAnimals(animals);
    }

    private static void DisplayAnimals(IEnumerable<Animal> animals)
    {
        foreach (var animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Species: {animal.Species}, Color: {animal.Color}");
        }
    }

}