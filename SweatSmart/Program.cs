// See https://aka.ms/new-console-template for more information

using SweatSmart.Exercises;
using SweatSmart.Test.Tests;
using SweatSmart.Test.Writers;

Console.WriteLine("Hello, World!");

// var exercise = new Exercise1();
//
// Console.WriteLine("Start Exercise: {0}", nameof(exercise));
// exercise.Theory();
// exercise.Run();
// Console.WriteLine("End Exercise: {0}", nameof(exercise));

var writer = new ConsoleWriter();
var test = new Test1(writer);
test.Run();