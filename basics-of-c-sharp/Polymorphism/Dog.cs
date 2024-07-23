namespace BasicsOfCSharp.Polymorphism
{
    public class Dog : Animal
    {
        public Dog(string name, string species, string color) : base(name, species, color)
        {
        }
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woff! woof");
        }
    }
}