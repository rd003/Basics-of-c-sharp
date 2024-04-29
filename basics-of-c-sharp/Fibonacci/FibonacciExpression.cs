namespace BasicsOfCSharp.Fibonacci;

public class FibonacciExpression
{
    public static int GetNthFibonacciNumber(int n)
    {
        double phi = (1 + Math.Sqrt(5)) / 2;
        return (int)Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
    }
}