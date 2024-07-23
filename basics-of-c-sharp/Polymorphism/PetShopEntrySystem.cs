namespace BasicsOfCSharp.Polymorphism;

public class PetShopEntrySystem
{
    private readonly List<Animal> animals;
    public PetShopEntrySystem()
    {
        animals = new List<Animal>();
    }
    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return animals;
    }
}
