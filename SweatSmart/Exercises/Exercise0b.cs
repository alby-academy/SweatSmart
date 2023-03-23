namespace SweatSmart.Exercises;

using Abstract;

/// <summary>
/// Supponiamo di avere un dizionario che associa il nome di una città al suo numero di abitanti. Dovremo effettuare le seguenti operazioni:
/// 1. Aggiungere una nuova città al dizionario.
/// 2. Rimuovere tutte le città con meno di 100.000 abitanti.
/// 3. Calcolare il numero totale di abitanti in tutte le città.
/// </summary>
public class Exercise0b : IExercise
{
    public void Theory() => Console.WriteLine("No theory found");

    public void Run()
    {
        var cities = new Dictionary<string, int>
        {
            { "Roma", 2856133 },
            { "Milano", 1399860 },
            { "Napoli", 973132 },
            { "Torino", 883281 },
            { "Firenze", 382258 }
        };

        var newCity = new City { Name = "Bologna", Population = 390000 };
        Console.WriteLine("Add a new key : value");
        cities.Add(newCity.Name,newCity.Population);

        Console.WriteLine();
        Console.WriteLine("After adding a city");
        foreach (var city in cities)
        {
            Console.WriteLine($"City {city.Key} Population: {city.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("Remove cities with less 100000 of population");
        foreach (var city in cities)
        {
            if (city.Value < 100000)
            {
                cities.Remove(city.Key);
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("After removing cities with less than 100000 of population");
        foreach (var city in cities)
        {
            Console.WriteLine($"City {city.Key} Population: {city.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("Total population in dictionary");
        var amountPopulation = 0;
        foreach (var city in cities)
        {
            amountPopulation += city.Value;
            Console.WriteLine($"After adding population of {city.Key}: {amountPopulation}");
        }
        Console.WriteLine($"Total amount population in dictionary: {amountPopulation}");
    }
    
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
    }
}