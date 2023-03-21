namespace SweatSmart.Abstract;

public abstract class LinqExercise : IExercise
{
    private const string LinqMethods= @"
            Ecco l'elenco di tutti i principali metodi LINQ disponibili nella libreria .NET:
            1) Aggregate: calcola un valore accumulato a partire da una sequenza
            2) All: determina se tutti gli elementi di una sequenza soddisfano una condizione
            3) Any: determina se almeno un elemento di una sequenza soddisfa una condizione
            4) Average: calcola la media di una sequenza di valori numerici
            5) Concat: concatena due sequenze
            6) Contains: determina se una sequenza contiene un valore specifico
            7) Count: restituisce il numero di elementi di una sequenza
            8) DefaultIfEmpty: restituisce una sequenza con un elemento predefinito se la sequenza originale è vuota
            9) Distinct: restituisce una sequenza senza duplicati
            10) ElementAt: restituisce l'elemento in una posizione specifica di una sequenza
            11) ElementAtOrDefault: restituisce l'elemento in una posizione specifica di una sequenza o un valore predefinito se la posizione è fuori range
            12) Except: restituisce gli elementi che non sono presenti in una seconda sequenza
            13) First: restituisce il primo elemento di una sequenza che soddisfa una condizione
            14) FirstOrDefault: restituisce il primo elemento di una sequenza che soddisfa una condizione o un valore predefinito se la sequenza è vuota
            15) GroupBy: raggruppa gli elementi di una sequenza in base a una chiave
            16) GroupJoin: effettua una join di gruppo tra due sequenze
            17) Intersect: restituisce gli elementi che sono presenti in entrambe le sequenze
            18) Join: effettua una join tra due sequenze
            19) Last: restituisce l'ultimo elemento di una sequenza che soddisfa una condizione
            20) LastOrDefault: restituisce l'ultimo elemento di una sequenza che soddisfa una condizione o un valore predefinito se la sequenza è vuota
            21) Max: restituisce il valore massimo di una sequenza di valori numerici
            22) Min: restituisce il valore minimo di una sequenza di valori numerici
            23) OrderBy: ordina gli elementi di una sequenza in base a una chiave
            24) OrderByDescending: ordina gli elementi di una sequenza in ordine decrescente in base a una chiave
            25) Range: restituisce una sequenza di numeri interi consecutivi
            26) Repeat: restituisce una sequenza di valori ripetuti un numero specifico di volte
            27) Reverse: inverte l'ordine degli elementi di una sequenza
            28) Select: proietta gli elementi di una sequenza
	        29) Zip: combina due sequenze element-wise utilizzando una funzione specificata
            30) SequenceEqual: determina se due sequenze sono uguali
            31) Skip: ignora i primi elementi di una sequenza e restituisce il resto
            32) SkipWhile: ignora gli elementi di una sequenza fino a quando non viene soddisfatta una condizione
            33) Take: restituisce i primi elementi di una sequenza fino a un numero specificato
            34) TakeWhile: restituisce gli elementi di una sequenza finché viene soddisfatta una condizione
            35) ThenBy: ordina gli elementi di una sequenza in base a una seconda chiave
            36) ThenByDescending: ordina gli elementi di una sequenza in base a una seconda chiave in ordine decrescente
            37) Union: restituisce gli elementi unici che sono presenti in entrambe le sequenze
            38) Where: filtra gli elementi di una sequenza in base a una condizione
            39) ToDictionary: crea un dizionario a partire da una sequenza di coppie chiave-valore
            40) ToList: consente di materializzare un'enumerazione una lista. Restituisce una nuova istanza di una lista che contiene gli elementi dell'enumerazione.
            41) ToArray: consente di materializzare un'enumerazione un'array. Restituisce un nuova istanza di un'array che contiene gli elementi dell'enumerazione.";
    
    public void Theory()
    {
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("Theory");    
        Console.WriteLine(LinqMethods);    
        Console.WriteLine("Theory");    
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
    }

    public abstract void Run();
}