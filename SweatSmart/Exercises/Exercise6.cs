namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Given a list of students, and two lists containing their math and science grades, find the name of the student who achieved the highest overall score, along with their grades.
///     Use Zip to combine the two grade lists, MaxBy to find the student with the highest total score and Anonymous Types.
///     Return a list containing only the best student.
/// </summary>
public class Exercise6 : IExercise<object>
{
    public IEnumerable<object> Run()
    {
        var studentNames = new List<string> { "Mario Rossi", "Luigi Bianchi", "Giovanni Verdi", "Marco Neri" };
        var mathGrades = new List<int> { 8, 9, 10, 6 };
        var scienceGrades = new List<int> { 7, 10, 8, 8 };

        var result = studentNames
            .Zip(mathGrades, (name, math) => new { Name = name, Math = math })
            .Zip(scienceGrades, (student, science) => new { student.Name, student.Math, Science = science })
            .ToList();

        var best = result.MaxBy(student => student.Math + student.Science);

        if (best is null)
            Console.WriteLine("Student not found");
        else
            Console.WriteLine("The best student is {0}, with math grade: {1} and science grade: {2}", best.Name, best.Math, best.Science);

        return new[] { best };
    }
}