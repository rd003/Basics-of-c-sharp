namespace basics_of_c_sharp.DesignPatterns.Decorator;

//  component interface
public interface IBook
{
    string GetDescription();
    double GetPrice();
}

// concrete component

public class Book : IBook
{
    public string Title { get; }
    public string Author { get; }

    public Book(string title,string author)
    {
        Title = title;
        Author = author;
    }

    public string GetDescription()
    {
        return $"Book: {Title} by {Author}";
    }

    public double GetPrice()
    {
        return 500; // base price
    }
}

// decorator abstract class

public abstract class BookDecorator : IBook
{
    protected IBook book;
    public BookDecorator(IBook book)
    {
        this.book = book;
    }

    public abstract string GetDescription();

    public abstract double GetPrice();
  
}

// Concrete decorator
public class HardcoverDecorator : BookDecorator
{
    public HardcoverDecorator(IBook book):base(book)
    {
        
    }
    public override string GetDescription()
    {
        return $"{book.GetDescription()}, Hardcover";
    }

    public override double GetPrice()
    {
        return book.GetPrice()+200; // Add hardcover cost
    }
}

// Concrete decorator
public class SignedCopyDecorator : BookDecorator
{
    public SignedCopyDecorator(IBook book):base(book)
    {
        
    }

    public override string GetDescription()
    {
        return $"{book.GetDescription()}, Signed Copy";
    }

    public override double GetPrice()
    {
        return book.GetPrice() + 100; // Add signed copy cost
    }

}

public class BookTestDrive
{
    public static void Main()
    {
        IBook book = new Book("C# in Depth", "Jon Skeet");
        Console.WriteLine(book.GetDescription() + ": " + book.GetPrice());

        // book with hard cover
        book = new HardcoverDecorator(book);
        Console.WriteLine(book.GetDescription() + ": " + book.GetPrice());

        // book with hard cover and signed copy
        book = new SignedCopyDecorator(book);
        Console.WriteLine(book.GetDescription() + ": " + book.GetPrice());

    }
}
