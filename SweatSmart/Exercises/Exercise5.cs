namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
///     Dato un elenco di numeri, trovare la somma dei quadrati dei numeri dispari e la radice quadrata della somma dei cubi dei numeri pari.
///     Utilizzare Where, Select, Aggregate e Math.
/// </summary>
public class Exercise5 : LinqExercise
{
    public override void Run()
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };

        var resultOdds = numbers
            .Where(n => n % 2 != 0)
            .Select(n => Math.Pow(n, 2))
            .Aggregate(0D, (acc, n) => acc + n);

        var resultEven = numbers
            .Where(n => n % 2 == 0)
            .Select(n => Math.Pow(n, 3))
            .Aggregate(0D, (acc, n) => acc + n);

        Console.WriteLine($"Somma dei quadrati dei numeri dispari {resultOdds}");
        Console.WriteLine($"Somma dei cubi dei numeri pari= {resultEven}. La radice quadrata della somma dei cubi dei numeri pari: {Math.Sqrt(resultEven)}");
    }
}