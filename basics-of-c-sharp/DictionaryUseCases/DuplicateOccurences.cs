namespace BasicsOfCSharp.DictionaryUseCases;

public class DuplicateOccurences
{
    public static void ExecuteMethod()
    {
        string[] names = ["Jack", "john", "jack", "max", "jason", "xiao", "jack", "max"];
        Dictionary<string, int> nameCounts = [];
        foreach (var name in names)
        {
            string normalizedName = name.ToLower();
            if (nameCounts.ContainsKey(name))
                nameCounts[normalizedName]++;
            else
                nameCounts[normalizedName] = 1;
        }
        Console.WriteLine("Total names with occurences");
        PrintNames(nameCounts);

        var duplicates = nameCounts.Where(a => a.Value > 1).ToDictionary();
        Console.WriteLine("Duplicate names");
        PrintNames(duplicates);
        Console.ReadLine();

        void PrintNames(Dictionary<string, int> names)
        {
            foreach (var kv in names)
            {
                Console.WriteLine($"Name: {kv.Key}, Counts: {kv.Value} ");
            }
        }
    }
}