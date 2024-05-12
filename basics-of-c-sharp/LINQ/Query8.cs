namespace BasicsOfCSharp.LINQ;

public class Query8
{
    public static void Execute()
    {
        var students = StudentData.GetStudents();

        var studentQuery = students.Where(s => s.Last == "Garcia").Select(s => s.First);
        foreach (var fName in studentQuery)
        {
            Console.WriteLine(fName);
        }
        Console.ReadLine();
    }
}

