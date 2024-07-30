namespace basics_of_c_sharp.DesignPatterns.AbstractFactory;

// Abstract Product A
public interface IButton
{
    void Render();
}

// Abstract Product B
public interface ICheckbox
{
    void Render();
}

// Concrete Product A1
public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a light button");
    }
}

// Concrete Product A2
public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a dark button");
    }
}

// Concrete Product B1
public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a light checkbox");
    }
}

// Concrete Product B2
public class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a dark checkbox");
    }
}

// Abstract Factory
public abstract class GUIFactory
{
    public abstract IButton CreateButton();
    public abstract ICheckbox CreateCheckbox();

}


// Concrete Factory 1
public class LightThemeFactory : GUIFactory
{
    public override IButton CreateButton()
    {
       return new LightButton();
    }

    public override ICheckbox CreateCheckbox()
    {
        return new LightCheckbox();
    }
}

// Concrete Factory 2
public class DarkThemeFactory : GUIFactory
{
    public override IButton CreateButton()
    {
        return new DarkButton();
    }

    public override ICheckbox CreateCheckbox()
    {
        return new DarkCheckbox();
    }
}

// Client
public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;

    public Application(GUIFactory guiFactory)
    {
        _button = guiFactory.CreateButton();
        _checkbox = guiFactory.CreateCheckbox();
    }

    public void Render()
    {
        _button.Render();
        _checkbox.Render();
    }
}



public class GuiFactoryTest
{
    public static void Main()
    {
        // Light theme client
        GUIFactory lightFactory = new LightThemeFactory();
        Application lightApp = new Application(lightFactory);
        lightApp.Render();

        // Dark theme client
        GUIFactory darkFactory = new DarkThemeFactory();
        Application darkApp = new Application(darkFactory);
        darkApp.Render();

        Console.ReadLine();
    }
}
