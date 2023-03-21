namespace SweatSmart.Exercises;

using SweatSmart.Abstract;

/// <summary>
/// Supponiamo di avere due elenchi di parole, A e B, e di dover trovare le parole che sono presenti solo in A o solo in B, ma non in entrambi.
/// Inoltre, vogliamo trovare le parole che sono presenti sia in A che in B, ma solo se hanno un numero pari di lettere.
/// Utilizzare Except, Union, Intersect.
/// </summary>
public class Exercise6 : LinqExercise
{
    public override void Run()
    {
        var a = new List<string> { "apple", "banana", "orange", "kiwi", "grape" };
        var b = new List<string> { "banana", "pear", "kiwi", "grapefruit", "cherry" };
        
        throw new NotImplementedException();
    }
}