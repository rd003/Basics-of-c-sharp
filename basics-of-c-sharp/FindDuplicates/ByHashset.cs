namespace BasicsOfCSharp.FindDuplicates;
public class ByHashset
{
    public static void ExecuteMethod()
    {
        int[] numbers = [4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8];
        HashSet<int> distinctNumbers = [];
        HashSet<int> duplicateNumbers = [];
        foreach (var number in numbers)
        {
            if (!distinctNumbers.Add(number))
            {
                duplicateNumbers.Add(number);
            }
        }

        Console.WriteLine("original array");
        PrintArray(numbers);

        Console.WriteLine("\nDistinct numbers");
        PrintArray(distinctNumbers.ToArray());

        Console.WriteLine("\nDuplicate numbers");
        PrintArray(duplicateNumbers.ToArray());

        Console.ReadKey();
    }

    private static void PrintArray(int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write($"{num},");
        }
    }
}