using SweatSmart.Test.Tests;
using SweatSmart.Test.Writers;

var writer = new ConsoleWriter();
var exercise = new Test1(writer);


Console.WriteLine("Start Exercise: {0}", nameof(exercise));

exercise.Run();
exercise.Write();

Console.WriteLine("End Exercise: {0}", nameof(exercise));
Console.ReadKey();