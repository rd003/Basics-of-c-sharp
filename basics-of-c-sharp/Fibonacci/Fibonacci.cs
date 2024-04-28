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
            // FibonacciBasic(num);
            for (int n = 1; n <= num; n++)
            {
                // int fib = FibonacciIterative.GetNthFibonacciNumber(n);
                int fib = FibonacciRecursive.GetNthFibonacciNumber(n);
                Console.Write($"{fib} ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }

}