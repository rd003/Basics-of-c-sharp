namespace BasicsOfCSharp.OCP;

public class Shape
{
  public void Draw(ShapeType shapeType)
  {
    switch (shapeType)
    {
      case ShapeType.Circle:
        DrawCircle();
        break;

      case ShapeType.Square:
        DrawSquare();
        break;

      case ShapeType.Rectangle:
        DrawRectangle();
        break;

      default:
        Console.WriteLine("Invalid shape type");
        break;
    }
  }

  private void DrawCircle()
  {
    Console.WriteLine("Drawing Circle");
  }

  private void DrawSquare()
  {
    Console.WriteLine("Drawing Square");
  }

  private void DrawRectangle()
  {
    Console.WriteLine("Drawing Rectangle");
  }
}

