namespace BasicsOfCSharp.OCPStrategy;

public abstract class Shape
{
    protected IShapeDrawStrategy shapeDrawStrategy;

    public void Draw()
    {
        shapeDrawStrategy.Draw();
    }
}

public class Rectangle : Shape
{
    public Rectangle()
    {
        shapeDrawStrategy = new RectangleDrawStrategy();
    }
}

public class Circle : Shape
{
    public Circle()
    {
        shapeDrawStrategy = new CircleDrawStrategy();
    }
}