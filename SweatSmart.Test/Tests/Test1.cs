namespace SweatSmart.Test.Tests;

using Abstract;

/// <summary>
///     Scrivere una query che dato lo User mi scriva un file excel contenente:
///     1) Id, Nome, Congnome e Email dell'Utente
///     2) Id dell'Ordine
///     3) Id dei prodotti separati da "," contenuti nell'Ordine
///     4) Il costo totale dell'ordine
///     Se un utente non ha ordini esso deve essere visualizzato come segue:
///     1) Id, Nome, Congnome e Email dell'Utente
///     2) Id Ordine = 0
///     3) string vuota
///     4) Il costo deve essere pari a 0
/// </summary>
public class Test1 : TestBase
{
    public Test1(IWriter writer) : base(writer, 10, 100, 100)
    {
    }

    public override void Run()
    {
    }
}