namespace basics_of_c_sharp.LSP.V;

public abstract class Bird
{
   public abstract void Eat();
   public abstract void MakeSound();
   public abstract void Fly();

   public void Sleep()
   {
        Console.WriteLine("Sleeping..");
   }
}

public class Sparrow : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Sparrow is eating..");
    }

    public override void Fly()
    {
        Console.WriteLine("Sparrow is flying..");
    }

    public override void MakeSound()
    {
        Console.WriteLine("chirp..");
    }
}

public class Penguin : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Penguin is eating..");
    }

    public override void Fly()
    {
        throw new NotImplementedException();
    }

    public override void MakeSound()
    {
        Console.WriteLine("chirp..");
    }
}

public class BirdTest
{
    public static void Main()
    {
        Bird sparrow = new Sparrow();
        sparrow.Fly();

        Bird penguin = new Penguin();
        penguin.Fly();
    }
}
