namespace BasicsOfCSharp.LINQ;

public class OrderedGroup
{
    public static void Execute()
    {
        var students = StudentData.GetStudents();

        IEnumerable<IGrouping<char, Student>> studentQuery =
        from student in students
        group student by student.Last[0] into studentGroup
        orderby studentGroup.Key
        select studentGroup;

        foreach (IGrouping<char, Student> studentGroup in studentQuery)
        {
            Console.WriteLine($"Key: {studentGroup.Key}");
            foreach (var student in studentGroup)
            {
                Console.WriteLine($"{student.Last} {student.First}");
            }
        }

        Console.ReadLine();
    }
}

