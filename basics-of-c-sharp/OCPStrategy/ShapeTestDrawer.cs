namespace BasicsOfCSharp.OCPStrategy;

public class ShapeTestDrive
{
    public static void Main()
    {
        // drawing a circle
        Shape circle = new Circle();
        circle.Draw();

        // drawing a rectangle
        Shape rectangle = new Rectangle();
        rectangle.Draw();
    }

}