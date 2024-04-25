namespace BasicsOfCSharp.TowSum;

public class TwoSumOptimized
{
    public static void ExecuteMethod()
    {
        int[] arr = [1, 15, 3, 2, 1, 14];
        int sum = 33; //
        (int i, int j) = GetTwoSumIndexes(arr, sum);
        if (i >= 0 && j >= 1)
        {
            Console.WriteLine($"indexes {i},{j}");
        }
        else
        {
            Console.WriteLine("Sum does not found");
        }
        Console.ReadKey();
    }
    private static (int, int) GetTwoSumIndexes(int[] arr, int sum)
    {

        return (-1, -1);
    }
}