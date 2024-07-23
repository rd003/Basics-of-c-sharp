namespace BasicsOfCSharp.OCP;

public class RectangleDrawStrategy : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}
