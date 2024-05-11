namespace BasicsOfCSharp.LINQ;

public class SimpleQuery
{
    public static void Execute()
    {
        var students = StudentData.GetStudents();
        var studentQuery = from student in students where student.Scores[0] > 90 select student;
        // var studentQuery = students.Where(student => student.Scores[0] > 90);
        foreach (Student student in studentQuery)
        {
            Console.WriteLine($"{student.First}{student.Last}");
        }

        Console.ReadLine();
    }
}

