namespace BasicsOfCSharp.FindDuplicates;
public class ByDictionary
{
    public static void ExecuteMethod()
    {
        int[] numbers = [4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8];

        Dictionary<int, int> numberCount = [];
        foreach (var num in numbers)
        {
            if (numberCount.ContainsKey(num))
                numberCount[num]++;
            else
                numberCount[num] = 1;
        }

        var distinctNumbers = numberCount.Where(kv => kv.Value >= 1).Select(a => a.Key).ToArray();
        var duplicateNumbers = numberCount.Where(kv => kv.Value > 1).Select(a => a.Key).ToArray();

        Console.WriteLine("Original Array");
        PrintArray(numbers);

        Console.WriteLine("Distinct numbers");
        PrintArray(distinctNumbers);

        Console.WriteLine("Duplicate numbers");
        PrintArray(duplicateNumbers);

        Console.ReadKey();
    }

    private static void PrintArray(int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}