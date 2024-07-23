
namespace BasicsOfCSharp.OCPStrategy;

public interface IShapeDrawStrategy
{
  void Draw();
}

public class CircleDrawStrategy : IShapeDrawStrategy
{
  public void Draw()
  {
    Console.WriteLine("Drawing a circle");
  }
}

public class RectangleDrawStrategy : IShapeDrawStrategy
{
  public void Draw()
  {
    Console.WriteLine("Drawing a rectangle");
  }
}
