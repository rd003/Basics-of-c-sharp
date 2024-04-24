namespace BasicsOfCSharp.FindDuplicates;
public class ByLinq
{
    public static void ExecuteMethod()
    {
        int[] numbers = [4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8];

        Console.WriteLine("Original Array");
        PrintArray(numbers);

        var distinctNumbers = numbers.Distinct().ToArray();
        Console.WriteLine("Distinct numbers");
        PrintArray(distinctNumbers);

        var duplicateNumbers = numbers.GroupBy(num => num).Where(n => n.Count() > 1).Select(n => n.Key).ToArray();
        Console.WriteLine("Duplicate numbers");
        PrintArray(duplicateNumbers);

        Console.ReadKey();
    }

    private static void PrintArray(int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write($"{num},");
        }
        Console.WriteLine();
    }
}