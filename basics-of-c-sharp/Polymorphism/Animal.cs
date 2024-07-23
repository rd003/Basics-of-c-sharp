namespace BasicsOfCSharp.Polymorphism;

public abstract class Animal
{
    public string Name { get; }
    public string Species { get; }
    public string Color { get; }

    public Animal(string name, string species, string color)
    {
        Name = name;
        Species = species;
        Color = color;
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }

    public abstract void Eat();
    public abstract void MakeSound();
}
