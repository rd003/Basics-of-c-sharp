namespace basics_of_c_sharp.DesignPatterns.SingletonPattern;

// Bad Code, not thread safe, do not use it

public sealed class Person
{
    private static readonly Lazy<Person> lazy =
        new Lazy<Person>(() => new Person());

    public string? Name { get; set; }
    public static Person Instance
    {
        get
        {
            return lazy.Value;
        }
    }
}