namespace SweatSmart.Exercises;

using Abstract;
using Extensions;
using Model;

/// <summary>
///     Suppose we have a dictionary that associates the name of a state with a collection of cities, where each city is represented by an object with string name and int population properties.
///     We need to perform the following operations without using LINQ:
///     1. Add a new Italian city to the dictionary.
///     2. Add 5 Spanish cities to the dictionary.
///     3. Remove all cities with less than one million inhabitants.
///     4. Calculate the total population of the Italian cities.
///     5. Calculate the total population in all cities around the world.
/// </summary>
public class Exercise2 : IExercise<string, ICollection<City>>
{
    public Dictionary<string, ICollection<City>> Run()
    {
        var states = GetStates();
        states.Print();

        AddItalianCity(states);
        states.Print();

        AddSpainCities(states);
        states.Print();

        RemoveCitiesLessThan1Million(states);
        states.Print();

        Console.WriteLine("Italian Population: {0}", CalculateStatePopulation(states, "italy"));
        Console.WriteLine("World Population: {0}", CalculateWorldPopulation(states));

        return states;
    }

    private static Dictionary<string, ICollection<City>> GetStates()
    {
        var italy = new List<City>
        {
            new("Rome", 2860009),
            new("Milan", 1371498),
            new("Triest", 204338),
            new("Florence", 367150),
            new("Naples", 909048)
        };

        var england = new List<City>
        {
            new("London", 8799800),
            new("Manchester", 551938),
            new("Leeds", 516298),
            new("Liverpool", 486100),
            new("Birmingham", 1144919)
        };

        var usa = new List<City>
        {
            new("Los Angles", 3898747),
            new("New York", 8804190),
            new("Dallas", 1304379),
            new("Chicago", 2746388),
            new("Detroit", 639111)
        };

        return new()
        {
            { "italy", italy },
            { "england", england },
            { "usa", usa }
        };
    }

    private static void AddItalianCity(IReadOnlyDictionary<string, ICollection<City>> states)
    {
        var city = new City("Venice", 258685);
        states["italy"].Add(city);
    }

    private static void AddSpainCities(IDictionary<string, ICollection<City>> states)
    {
        var spain = new List<City>
        {
            new("Madrid", 3223334),
            new("Barcelona", 1620343),
            new("Valencia", 789744),
            new("Seville", 684234),
            new("Granada", 232208)
        };

        states.Add("spain", spain);
    }

    private static void RemoveCitiesLessThan1Million(Dictionary<string, ICollection<City>> states, int? bound = default)
    {
        IEnumerable<City> CitiesToRemove(KeyValuePair<string, ICollection<City>> country)
        {
            foreach (var city in country.Value)
                if (city.Population < (bound ?? 1E6))
                    yield return city;
        }

        foreach (var country in states)
        {
            var citiesToRemove = CitiesToRemove(country).ToList();

            foreach (var city in citiesToRemove) country.Value.Remove(city);
        }
    }

    private static int CalculateStatePopulation(IDictionary<string, ICollection<City>> states, string state)
    {
        var found = states.TryGetValue(state, out var cities);

        if (!found) return 0;

        var acc = 0;

        foreach (var city in cities) acc += city.Population;

        return acc;
    }

    private static int CalculateWorldPopulation(IDictionary<string, ICollection<City>> states)
    {
        var acc = 0;
        foreach (var state in states)
        foreach (var city in state.Value)
            acc += city.Population;

        return acc;
    }
}