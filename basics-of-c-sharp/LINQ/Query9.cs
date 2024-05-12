namespace BasicsOfCSharp.LINQ;

public class Query9
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

        var aboveAverageQuery = from student in students
                                let x = student.Scores[0] + student.Scores[1] +
                                student.Scores[2] + student.Scores[3]
                                where x > averageScore
                                select new { id = student.ID, score = x };
        foreach (var item in aboveAverageQuery)
        {
            Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
        }
        Console.ReadLine();
    }
}

