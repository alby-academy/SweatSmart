namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
/// Supponiamo di avere una lista di persone e di dover effettuare le seguenti operazioni, senza usare Linq:
/// 1. Aggiungere una nuova persona alla lista.
/// 2. Rimuovere tutte le persone con un'età inferiore a 18 anni.
/// 3. Aggiornare l'età di tutte le persone presenti nella lista di 1 anno.
/// </summary>
public class Exercise0 : IExercise
{
    public void Theory()
    {
        Console.WriteLine("No theory found");
    }

    public void Run()
    {
        var people = new List<Person>
        {
            new() { Name = "Mario", Age = 35 },
            new() { Name = "Luigi", Age = 22 },
            new() { Name = "Giovanni", Age = 17 },
            new() { Name = "Maria", Age = 25 },
            new() { Name = "Paola", Age = 12 }
        };

    }
    
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}