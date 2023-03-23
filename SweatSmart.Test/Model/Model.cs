namespace SweatSmart.Test.Model;

public record Product(int Id, string Name, decimal Price);

public record User(int Id, string Email, string GivenName, string FamilyName);

public record Order(int UserId, int ProductId, int Quantity, DateTime OccuredOn);