namespace BasicsOfCSharp.Fibonacci;

public class Fibonacci
{
    public static void PrintSeries()
    {
        Console.WriteLine("How many numbers you want to print???");
        bool valid = int.TryParse(Console.ReadLine(), out int num);
        if (valid)
            FibonacciBasic(num);
        else
            Console.WriteLine("Invalid entry");
        Console.ReadLine();
    }

    private static int FibonacciBasic(int n = 1)
    {
        if (n < 3)
        {
            Console.WriteLine("atleast print 3 numbers");
            return 0;
        }
        int n1 = 1;
        int n2 = 1;
        int n3;
        Console.Write($"{n1} {n2} ");
        for (int i = 3; i <= n; i++)
        {
            n3 = n1 + n2;
            Console.Write($"{n3} ");
            n1 = n2;
            n2 = n3;
        }
        return 0;
    }
}