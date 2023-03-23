namespace SweatSmart.Exercises;

using Abstract;

// Esercizio 10
// Supponi di avere una lista di numeri. Crea un programma che utilizzi il metodo GroupBy per raggruppare i numeri
// in base al loro valore pari o dispari e creare un dizionario contenente due gruppi di numeri:
// uno per i numeri pari e uno per i numeri dispari. Utilizza il metodo ToDictionary per creare il dizionario.
// Infine, stampa i numeri di ciascun gruppo sulla console, utilizzando un ciclo foreach.
public class Exercise10 : LinqExercise
{
    public override void Run()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var result = numbers
            .GroupBy(n => n % 2 == 0 ? "Even" : "Odd")
            .ToDictionary(g => g.Key, g => g);

        foreach (var group in result)
        {
            Console.WriteLine($"Numbers {group.Key}:{string.Join(", ", group.Value)}");
        }
    }
}