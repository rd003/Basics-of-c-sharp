namespace BasicsOfCSharp.Polymorphism
{
    public class Cat : Animal
    {
        public Cat(string name, string species, string color) : base(name, species, color)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meau...!");
        }
    }
}