using SweatSmart.Exercises;
using SweatSmart.Extensions;

var exercise = new Exercise1();

var type = exercise.GetType().Name;
Console.WriteLine("Start Exercise: {0}", type);

var result = exercise.Run();
result.Print();

Console.WriteLine("End Exercise: {0}", type);
Console.ReadKey();