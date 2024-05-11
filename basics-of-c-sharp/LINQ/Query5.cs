namespace BasicsOfCSharp.LINQ;

public class Query5
{
    public static void Execute()
    {
        var students = StudentData.GetStudents();

        // This query returns those students whose
        // first test score was higher than their
        // average score.
        var studentQuery =
        from student in students
        let totalScore = student.Scores[0] + student.Scores[1] +
        student.Scores[2] + student.Scores[3]
        where student.Scores[0] > totalScore / 4
        select $"{student.Last}, {student.First}";

        foreach (var s in studentQuery)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}

