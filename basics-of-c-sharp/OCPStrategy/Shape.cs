namespace BasicsOfCSharp.OCPStrategy;

public abstract class Shape
{
    protected IShapeDrawStrategy shapeDrawStrategy;

    public abstract void Draw();
}

public class Rectangle : Shape
{
    public Rectangle()
    {
        shapeDrawStrategy = new RectangleDrawStrategy();
    }
    public override void Draw()
    {
        shapeDrawStrategy.Draw();
    }
}

public class Circle : Shape
{
    public Circle()
    {
        shapeDrawStrategy = new CircleDrawStrategy();
    }
    public override void Draw()
    {
        shapeDrawStrategy.Draw();
    }
}