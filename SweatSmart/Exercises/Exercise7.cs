namespace SweatSmart.Exercises;

using Abstract;

// Esercizio 7
// Supponiamo di avere un elenco di 1000 numeri interi casuali compresi tra 1 e 10000.
// Vogliamo creare una nuova sequenza che soddisfi le seguenti condizioni:
//    1) Contiene i primi 5 numeri della sequenza originale.
//    2) Contiene tutti i numeri nella sequenza originale che sono maggiori di 5000,
//       fino a quando non viene raggiunto il primo numero inferiore a 5000.
// 	  3) Salta i primi 200 numeri della sequenza originale.
//    4) Salta tutti i numeri nella sequenza originale che sono inferiori a 3000.
//	  5) Invertire i numeri nella sequenza risultante
// Utilizzare Take, Range, Select, Concat, Skip, SkipWhile, Reverse
public class Exercise7 : LinqExercise
{
    public override void Run()
    {
        var rnd = new Random();
        var listNumbers = Enumerable
            .Range(1, 10000)
            .Select(item => rnd.Next(1, 10001)).ToList();

        var res = listNumbers
            .Take(5)
            .Concat(listNumbers.TakeWhile(x => x > 5000))
            .Skip(200)
            .SkipWhile(x => x < 3000)
            .Reverse();

        foreach (var i in res) Console.WriteLine(i);
    }
}