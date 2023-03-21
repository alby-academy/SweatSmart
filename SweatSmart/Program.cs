// See https://aka.ms/new-console-template for more information

using SweatSmart.Exercises;

Console.WriteLine("Hello, World!");

var exercise = new Exercise1();

Console.WriteLine("Start Exercise: {0}", nameof(exercise));
exercise.Theory();
exercise.Run();
Console.WriteLine("End Exercise: {0}", nameof(exercise));
