namespace BasicsOfCSharp.Fibonacci;

public class Fibonacci
{
    public static void PrintSeries()
    {
        Console.WriteLine("How many numbers you want to print???");
        bool valid = int.TryParse(Console.ReadLine(), out int num);
        if (!valid)
            Console.WriteLine("Invalid entry");
        else
        {
            FibonacciBasic(num);
        }
        Console.ReadLine();
    }

    private static int FibonacciBasic(int n = 1)
    {
        if (n < 3)
        {
            Console.WriteLine("atleast print 3 numbers");
            return 0;
        }
        int fib = 1;
        int prevFib = 1;
        Console.Write($"{fib} {prevFib} ");
        for (int i = 3; i <= n; i++)
        {
            int temp = fib;
            fib += prevFib;
            Console.Write($"{fib} ");
            prevFib = temp;
        }
        return 0;
    }

    private static int GetNthFibonacciNumber(int n = 1)
    {
        if (n <= 1)
            return n;
        int fib = 1;
        int prevFib = 1;
        for (int i = 2; i < n; i++)
        {
            int temp = fib;
            fib += prevFib;
            prevFib = temp;
        }
        return fib;
    }

}