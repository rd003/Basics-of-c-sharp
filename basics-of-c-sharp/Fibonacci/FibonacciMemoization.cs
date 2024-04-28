namespace BasicsOfCSharp.Fibonacci;

public class FibonacciMemoization
{
    public static int GetNthFibonacciNumber(int n)
    {
        int[] memo = new int[n + 1];
        return FibonacciHelper(n, memo);
    }

    private static int FibonacciHelper(int n, int[] memo)
    {
        if (n <= 1) return n;
        else if (memo[n] == 0)
            memo[n] = FibonacciHelper(n - 1, memo) + FibonacciHelper(n - 2, memo);
        return memo[n];
    }
}