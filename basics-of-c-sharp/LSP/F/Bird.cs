namespace basics_of_c_sharp.LSP.F;

// solution 2
//public interface IBird
//{
//    void Eat();
//    void MakeSound();
//    void Sleep();
//}

//public interface IFlyableBird:IBird
//{
//    void Fly();
//}

//public abstract class Bird
//{
//    public abstract void Eat();
//    public abstract void MakeSound();

//    public void Sleep()
//    {
//        Console.WriteLine("Sleeping..");
//    }
//}



//public class Sparrow : Bird, IFlyableBird
//{
//    public override void Eat()
//    {
//        Console.WriteLine("Sparrow is eating..");
//    }

//    public void Fly()
//    {
//        Console.WriteLine("Sparrow is flying..");
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine("chirp..");
//    }
//}

//public class Penguin : Bird
//{
//    public override void Eat()
//    {
//        Console.WriteLine("Penguin is eating..");
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Penguin's sound");
//    }
//}

//public class BirdTest
//{
//    public static void Main()
//    {
//        Console.WriteLine("Sparrow's behaviors\n");
//        IFlyableBird sparrow = new Sparrow();
//        sparrow.Fly();
//        sparrow.MakeSound();
//        sparrow.Eat();
//        sparrow.Sleep();

//        Console.WriteLine("\nPenguine's behaviors");
//        Bird penguin = new Penguin();
//        penguin.Eat();
//        penguin.Sleep();
//        penguin.MakeSound();

//    }
//}


// solution #1
public interface IBird
{
    void Eat();
    void MakeSound();
    void Sleep();
}

public interface IFlyableBird:IBird
{
    void Fly();
}

public class Sparrow : IFlyableBird
{
    public void Eat()
    {
        Console.WriteLine("Sparrow is eating..");
    }

    public void Fly()
    {
        Console.WriteLine("Sparrow is flying..");
    }

    public  void MakeSound()
    {
        Console.WriteLine("chirp..");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

public class Penguin : IBird
{
    public  void Eat()
    {
        Console.WriteLine("Penguin is eating..");
    }

    public void MakeSound()
    {
        Console.WriteLine("Penguin's sound");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}


public class BirdTest
{
    public static void Main()
    {
        Console.WriteLine("Sparrow's behaviors\n");

        IFlyableBird sparrow = new Sparrow();
        sparrow.Fly();
        sparrow.MakeSound();
        sparrow.Eat();
        sparrow.Sleep();

        Console.WriteLine("\nPenguine's behaviors");
        IBird penguin = new Penguin();
        penguin.Eat();
        penguin.Sleep();
        penguin.MakeSound();

    }
}
