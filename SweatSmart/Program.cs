using SweatSmart.Exercises;

var exercise = new Exercise4();


Console.WriteLine("Start Exercise: {0}", nameof(exercise));
exercise.Theory();
exercise.Run();
Console.WriteLine("End Exercise: {0}", nameof(exercise));
Console.ReadKey();