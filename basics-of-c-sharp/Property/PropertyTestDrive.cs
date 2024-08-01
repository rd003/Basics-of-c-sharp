
namespace basics_of_c_sharp.Property;

//public class Person
//{
//    public string Name { get; set; }

//    public int Age { get; set; }
//}

public abstract class Animal
{
    public  string Name { get; set; }
}

public class Dog : Animal
{
    public override string Name 
    {
        get
        {
          return ""
        } 
}

public class PropertyTestDrive
{
    public static void Main()
    {
        
    }
}
