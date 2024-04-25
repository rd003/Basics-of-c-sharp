namespace BasicsOfCSharp.TowSum;

public class TwoSumOptimized
{
    public static void ExecuteMethod()
    {
        int[] arr = [1, 15, 3, 2, 1, 14];
        Console.WriteLine("Given array: ");
        PrintArray(arr);
        Console.WriteLine();

        // testing multiple inputs
        int[] possibleSumInputs = [15, 4, 29, 30, 9, 2, 17, 16, 22, 55, 16];
        foreach (int sum in possibleSumInputs)
        {
            (int index1, int index2) = GetTwoSumIndexes(arr, sum, out Dictionary<int, int> numCount);
           
            if (index1 >= 0 && index2 >= 1)
                Console.WriteLine($"For sum: {sum} | indexes {index1},{index2}");
            else
                Console.WriteLine($"For sum: {sum} |  indexes does not found");
            // also looking at dictionary, to get actual dictionary
            PrintDictionary(numCount);

        }
        Console.ReadKey();
    }

    private static void PrintDictionary(Dictionary<int, int> numCount)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("********* Dictionary Entries [item : index] *************");
        foreach (var kv in numCount)
        {
            Console.Write($"[{kv.Key}: {kv.Value}] ");
        }
        Console.ResetColor();
        Console.WriteLine("\n");
    }

    private static (int index1, int index2) GetTwoSumIndexes(int[] arr, int sum, out Dictionary<int, int> numCount)
    {
        // complement= sum-arr[i]
        // if complement is present as the key in the dictionary, then return i and dictionary[complement]
        // store arr[i] as key, i as value in thectionary, if dictionary does not contain the key as arr[i]
        numCount = [];
        for (int i = 0; i < arr.Length; i++)
        {
            int complement = sum - arr[i];
            if (numCount.ContainsKey(complement))
            {
                return (numCount[complement], i);
            }
            if (!numCount.ContainsKey(arr[i]))
            {
                numCount[arr[i]] = i;
            }
        }


        return (-1, -1);
    }

    private static void PrintArray(int[] arr)
    {
        Console.ForegroundColor= ConsoleColor.Cyan;
        foreach (int n in arr)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
        Console.ResetColor();
    }
}