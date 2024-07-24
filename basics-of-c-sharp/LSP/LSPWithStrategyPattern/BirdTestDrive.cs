
namespace basics_of_c_sharp.LSP.LSPWithStrategyPattern;

public interface IFlyBehavior
{
    public void Fly();
}

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with wings");
    }
}

public class NoFly : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I cant fly");
    }
}
public abstract class Bird
{
    public IFlyBehavior flyBehavior;
    public abstract void Eat();
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("Sleeping..");
    }

    public void Fly()
    {
        flyBehavior.Fly();
    }
}

public class Sparrow : Bird
{
    public Sparrow()
    {
        flyBehavior = new FlyWithWings();
    }

    public override void Eat()
    {
        Console.WriteLine("Sparrow is eating..");
    }

    public override void MakeSound()
    {
        Console.WriteLine("chirp..");
    }
}

public class Penguin : Bird
{
    public Penguin()
    {
        flyBehavior = new NoFly();
    }

    public override void Eat()
    {
        Console.WriteLine("Penguin is eating..");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Penguin is making sound");
    }
}

public class BirdTestDrive
    {
        public static void Main()
        {
        Console.WriteLine("Sparrow's behaviors\n");

        Bird sparrow = new Sparrow();
        sparrow.Eat();
        sparrow.Sleep();
        sparrow.MakeSound();
        sparrow.Fly();


        Console.WriteLine("\nPenguine's behaviors");
        Bird penguin = new Penguin();
        penguin.Eat();
        penguin.Sleep();
        penguin.MakeSound();
        penguin.Fly();
    }
}
