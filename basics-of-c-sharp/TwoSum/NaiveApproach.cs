namespace BasicsOfCSharp.TowSum;

public class NaiveApproach
{
    public static void ExecuteMethod()
    {
        int[] arr = [1, 15, 3, 2, 1, 14];
        Console.WriteLine("array: ");
        PrintArray(arr);
        int[] possibleSumInputs = [15, 4, 29, 30, 9, 2, 17, 16, 22, 55, 16];
        foreach (int sum in possibleSumInputs)
        {
            (int index1, int index2) = GetTwoSumIndexes(arr, sum);
            if (index1 >= 0 && index2 >= 1)
                Console.WriteLine($"For sum: {sum} | indexes {index1},{index2}");
            else
                Console.WriteLine($"For sum: {sum} |  indexes does not found");
        }
        Console.ReadKey();
    }
    private static (int index1, int index2) GetTwoSumIndexes(int[] arr, int sum)
    {
        for (int i = 0; i <= arr.Length - 2; i++)
        {
            for (int j = i + 1; j <= arr.Length - 1; j++)
            {
                if (arr[i] + arr[j] == sum)
                {
                    return (i, j);
                }
            }
        }
        return (-1, -1);
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int n in arr)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
    }
}