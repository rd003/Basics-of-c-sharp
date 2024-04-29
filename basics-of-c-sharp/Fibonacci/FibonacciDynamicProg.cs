namespace BasicsOfCSharp.Fibonacci;

public class FibonacciDynamicProg
{
    public static int GetNthFibonacciNumber(int n)
    {
        if (n <= 1) return 1;
        int[] fib = new int[n + 1];
        fib[0] = 1;
        fib[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        return fib[n];
    }

    public static void PrintSeries(int n)
    {
        int[] fib = new int[n + 1];
        fib[0] = 1;
        fib[1] = 1;
        Console.Write($"{fib[0]} {fib[1]} ");
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
            Console.Write($"{fib[i]} ");
        }
    }
}