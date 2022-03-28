namespace BoardingPassShared.Models;

public class Passenger
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    [JsonIgnore]
    public string DisplayName => $"{FirstName} {LastName}";
}