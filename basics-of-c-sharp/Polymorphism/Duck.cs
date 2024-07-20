namespace BasicsOfCSharp.Polymorphism;

public class Duck
{
    // override method, without virtual or abstract method.
    public void Quack()
    {
        Console.WriteLine("Duck is quacking");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swiming");
    }

    public virtual void Display()
    {
        Console.WriteLine("Duck is displaying");
    }
}

public class MallardDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("MallardDuck is displaying");
    }
}