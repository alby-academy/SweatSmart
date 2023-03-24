namespace SweatSmart.Model;

public record Person(string GivenName, string FamilyName, string Email, int Age);

public record City(string Name, int Population);

public record Product(string Name, decimal Price, string? Category = default);