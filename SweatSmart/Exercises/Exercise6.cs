namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Supponiamo di avere due elenchi di parole, A e B, e di dover trovare le parole che sono presenti solo in A o solo in B,
///     ma non in entrambi.
///     Inoltre, vogliamo trovare le parole che sono presenti sia in A che in B, ma solo se hanno un numero pari di lettere.
///     Utilizzare Except, Union, Intersect.
/// </summary>
public class Exercise6 : LinqExercise
{
    public override void Run()
    {
        var a = new List<string> { "apple", "banana", "orange", "kiwi", "grape" };
        var b = new List<string> { "banana", "pear", "kiwi", "grapefruit", "cherry" };

        var result = a.Union(b).Except(b.Intersect(a));

        foreach (var i in result) Console.WriteLine($"Elements only in A and only in B: {i}");

        var result2 = a.Intersect(b).Where(n => n.Length % 2 == 0);

        foreach (var i in result2) Console.WriteLine($"Intersection A B when string length is even: {i}");
    }
}