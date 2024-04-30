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

    public static void MethodTwo()
    {
        int[][,] jaggedArray = [
            new int[,]{{5,7},{17,9}},
            new int[,]{{1,3},{2,4},{3,6}},
            new int[,] {{11,10},{1001,1005},{1925,2981}}
        ];
        // Console.WriteLine(jaggedArray[0][1, 0]);
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            // Console.Write($"length of jaggedArray {i}={jaggedArray[i].GetLength(0)}");
            for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
            {
                Console.Write("[");
                for (int k = 0; k < jaggedArray[i].GetLength(1); k++)
                {
                    Console.Write($"{jaggedArray[i][j, k]} ");
                }
                Console.Write("]");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

}
