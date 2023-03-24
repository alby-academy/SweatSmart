namespace SweatSmart.Exercises;

using Abstract;
using Extensions;
using Model;

/// <summary>
///     Suppose we have a list of people, where each person is represented by a class with string properties for given name, family name, email, and an integer property for age.
///     We need to perform the following operations without using LINQ:
///     1. Add a new person to the list.
///     2. Add a list of 3 people to the list.
///     3. Remove all people with an age less than 18 years old.
///     4. Update the age of all people in the list by 1 year.
/// </summary>
public class Exercise1 : IExercise<Person>
{
    public IEnumerable<Person> Run()
    {
        var people = GetPeople();
        people.Print();

        AddPerson(people);
        people.Print();

        AddPersons(people);
        people.Print();

        RemovePersonsYoungerThan(people);
        people.Print();

        return AddAgesToAllPersons(people);
    }

    private static List<Person> GetPeople() => new()
    {
        new("Paolo", "Ferrari", "paolo.rossi@email.it", 30),
        new("Giuseppe", "Lamborghini", "giuseppe.verdi@email.it", 75),
        new("Marco", "Maserati", "marco.blu@email.it", 27)
    };

    private static void AddPerson(ICollection<Person> people)
    {
        var person = new Person("Luigi", "Bianchi", "luigi.bianchi@email.it", 33);
        people.Add(person);
    }

    private static void AddPersons(List<Person> people)
    {
        var newPeople = new List<Person>
        {
            new("Paolo", "Rossi", "paolo.rossi@email.it", 30),
            new("Giuseppe", "Verdi", "giuseppe.verdi@email.it", 17),
            new("Marco", "Neri", "marco.blu@email.it", 17)
        };
        people.AddRange(newPeople);
    }

    private static void RemovePersonsYoungerThan(IList<Person> people, int bound = 18)
    {
        for (var i = people.Count - 1; i >= 0; i--)
            if (people[i].Age < bound)
                people.RemoveAt(i);
    }

    private static IEnumerable<Person> AddAgesToAllPersons(IEnumerable<Person> people, int increment = 1)
    {
        foreach (var person in people) yield return person with { Age = person.Age + 1 };
    }
}