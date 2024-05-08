// The Three Parts of a LINQ Query:
// 1. Data source.
int[] numbers = Enumerable.Range(1, 10).ToArray();

// 2. Query creation.
// var numQuery = from num in numbers
//                where num % 2 == 0
//                select num;
var numQuery = numbers.Where(a => a % 2 == 0);

foreach (int num in numQuery)
{
    Console.Write("{0} ", num);
}

Console.ReadLine();