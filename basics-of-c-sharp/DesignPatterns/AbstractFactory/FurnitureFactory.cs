namespace basics_of_c_sharp.DesignPatterns.AbstractFactory;

// Abstract Product A
public interface IChair
{
    void SitOn();
}


// Concrete Product A1
public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Modern chair");
    }
}

// Concrete Product A2
public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair");
    }
}

// Abstract Product B
public interface ICoffeeTable
{
    void PutCoffee();
}

// Concrete Product B1
public class ModernCoffeeTable : ICoffeeTable
{
    public void PutCoffee()
    {
        Console.WriteLine("Putting coffee on a Modern coffee table");

    }
}

// Concrete Product B2
public class VictorianCoffeeTable : ICoffeeTable
{
    public void PutCoffee()
    {
        Console.WriteLine("Putting coffee on a Victorian coffee table");
    }
}

// Abstract Factory
public abstract class FurnitureFactory
{
    public abstract IChair CreateChair();
    public abstract ICoffeeTable CreateCoffeTable();
}

// Concrete Factory 1
public class ModernFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair()
    {
        return new ModernChair();
    }

    public override ICoffeeTable CreateCoffeTable()
    {
        return new ModernCoffeeTable();
    }
}

// Concrete Factory 2
public class VictorianFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair()
    {
        return new VictorianChair();
    }

    public override ICoffeeTable CreateCoffeTable()
    {
        return new VictorianCoffeeTable();
    }
}

// Client

public class Client
{
    private readonly FurnitureFactory _furnitureFactory;

    public Client(FurnitureFactory furnitureFactory)
    {
        _furnitureFactory = furnitureFactory;
    }

    public void UseFurniture()
    {
        IChair chair =_furnitureFactory.CreateChair();
        ICoffeeTable table=_furnitureFactory.CreateCoffeTable();

        chair.SitOn();
        table.PutCoffee();
    }
}


public class FurnitureTestDrive
{
    public static void Main()
    {
        // modern furniture client
        FurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();
        Client modernFurnitureClient = new Client(modernFurnitureFactory);
        modernFurnitureClient.UseFurniture();

        // victorian furniture client
        FurnitureFactory victorianFurnitureFactory = new VictorianFurnitureFactory();
        Client victorianFurnitureClient = new Client(victorianFurnitureFactory);
        victorianFurnitureClient.UseFurniture();

        Console.ReadLine();
    }
}