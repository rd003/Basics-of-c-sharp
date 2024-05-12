namespace BasicsOfCSharp.LINQ;

public class Query7
{
    public static void Execute()
    {
        var students = StudentData.GetStudents();

        var studentQuery =
    from student in students
    let totalScore = student.Scores[0] + student.Scores[1] +
        student.Scores[2] + student.Scores[3]
    select totalScore;

        double averageScore = studentQuery.Average();
        Console.WriteLine("Class average score = {0}", averageScore);

        // Output:
        // Class average score = 334.166666666667
        Console.ReadLine();
    }
}

