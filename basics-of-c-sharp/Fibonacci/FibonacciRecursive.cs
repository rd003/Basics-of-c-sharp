namespace BasicsOfCSharp.Fibonacci;

public class FibonacciRecursive
{
    public static int GetNthFibonacciNumber(int n)
    {
        if (n <= 1) return n;
        return GetNthFibonacciNumber(n - 1) + GetNthFibonacciNumber(n - 2);
    }
}