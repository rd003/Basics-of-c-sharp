using System.Text.RegularExpressions;

namespace BasicsOfCSharp.DictionaryUseCases;

public class CountOccurrences
{
    public static void ExecuteCountOccurences()
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ipsum dolor lorem amet";
        string[] words = Regex.Matches(text, @"\w+")
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToArray();
        Dictionary<string, int> wordCounts = [];
        foreach (string word in words)
        {
            string normalizedWord = word.ToLower();
            if (wordCounts.ContainsKey(normalizedWord))
                wordCounts[normalizedWord]++;
            else
                wordCounts[normalizedWord] = 1;
        }

        foreach (KeyValuePair<string, int> kvp in wordCounts)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }

        Console.ReadLine();
    }
}