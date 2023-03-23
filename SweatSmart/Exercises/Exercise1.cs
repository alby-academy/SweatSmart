namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
/// Dati due elenchi di studenti, uno contenente i voti di matematica e l'altro i voti di scienze, trovare il nome dello studente che ha
/// ottenuto il punteggio più alto complessivo, insieme ai relativi voti.
/// Utilizzare Zip per accoppiare i voti dei due elenchi, Max per trovare il punteggio più alto e Where per trovare
/// lo studente con quel punteggio.
/// </summary>
public class Exercise1 : LinqExercise
{
    public override void Run()
    {
        var studentNames = new List<string> { "Mario Rossi", "Luigi Bianchi", "Giovanni Verdi", "Marco Neri" };
        var mathGrades = new List<int> { 8, 9, 10, 6 };
        var scienceGrades = new List<int> { 7, 10, 9, 8 };

        var result = studentNames
            //unisco gli attributi e creo la tabella
            .Zip(scienceGrades, mathGrades)
            //clausa dove verifico la somma dei voti con lo studente
            .Where(p => p.Second + p.Third == studentNames
            //copia della tabela
            .Zip(scienceGrades, mathGrades)
            //prendo ogni somma massima
            .Max(x => x.Second + x.Third))
            //proietto il risultato 
            .Select(p => $"{p.First} è il miglior studente con un {p.Second} in scienze e un {p.Third} in matematica! ");
        
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }

    }
}