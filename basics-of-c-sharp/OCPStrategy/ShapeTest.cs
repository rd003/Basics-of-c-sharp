namespace BasicsOfCSharp.OCP;

public class ShapeTest
{
    public static void Main()
    {
        // Drawing a circle
        DrawShape(new Circle());

        //Drawing a rectangle
        DrawShape(new Rectangle());

        // Drawing a triangle
        DrawShape(new Triangle());

    }

    private static void DrawShape(IShape shape)
    {
        shape.Draw();
    }
}