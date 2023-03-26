using SweatSmart;
using SweatSmart.Extensions;

var exercises = Bootstrapper.GetExercises();

foreach (var (exercise, name) in exercises)
{
    name.PrintSeparator();

    var result = exercise();
    result.Print();
}

Console.ReadKey();