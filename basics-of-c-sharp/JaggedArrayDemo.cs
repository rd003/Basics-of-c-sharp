public class JaggedArrayDemo
{
    public static void MethodOne()
    {
        // int[][] jaggedArray = new int[3][];
        // jaggedArray[0] = [1, 3, 5, 7, 9];
        // jaggedArray[1] = [2, 4, 6, 8];
        // jaggedArray[2] = [11, 13, 17];
        int[][] jaggedArray = [[1, 3, 5, 7, 9], [2, 4, 6, 8], [11, 13, 17]];
        PrintJaggedArray(jaggedArray);

        // replacing inner array
        Console.WriteLine("replacing the element [1]");
        jaggedArray[1] = [2, 5, 7, 19];
        PrintJaggedArray(jaggedArray);

        Console.WriteLine("Updating the element [1,2]");
        jaggedArray[1][2] = 16;
        PrintJaggedArray(jaggedArray);

        Console.WriteLine("Appending new array");
        Array.Resize(ref jaggedArray, jaggedArray.Length + 1);
        jaggedArray[jaggedArray.Length - 1] = new int[] { 34, 35, 36, 37 };
        PrintJaggedArray(jaggedArray);
    }

    static void PrintJaggedArray(int[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"{jaggedArray[i][j]} ");
            }
            Console.WriteLine();
        }

    }

}
