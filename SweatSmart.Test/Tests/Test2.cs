namespace SweatSmart.Test.Tests;

using Abstract;

/// <summary>
///     /// Scrivere una query che dato un prodotto mi restituisca:
///     1) Id Nome e Prezzo del Prodotto
///     2) Id degli utenti che hanno acquistato quel prodotto separati da ","
///     3) Il numero totale di quante volte il prodotto e' stato venduto
///     Se un prodotto non ha ordini esso deve essere visualizzato come segue:
///     1) Id Nome e Prezzo del Prodotto
///     2) stringa vuota
///     3) 0
/// </summary>
public class Test2 : TestBase
{
    public Test2(IWriter writer) : base(writer, 100, 10, 50)
    {
    }

    public override void Run()
    {
        Write();
    }
}