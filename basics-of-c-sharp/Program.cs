using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace BasicsOfCSharp;
public class Program
{
    static void Main()
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ipsum dolor lorem amet";
        string[] words = Regex.Matches(text, @"\w+")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
        Dictionary<string, int> wordCount = new();
        foreach(var word in words)
        {
            string normalizedWord = word.ToLower().Trim();
            if (wordCount.ContainsKey(normalizedWord))
            {
                wordCount[normalizedWord]++;
            }
            else
            {
                wordCount[normalizedWord] = 1;
            }
        }
        foreach(KeyValuePair<string,int> wcp  in wordCount) 
        {
            Console.WriteLine($"{wcp.Key}:{wcp.Value}");
        }
    }
}