namespace BoardingPassShared.Models;

public class Flight
{
    public string? Code { get; set; }
    public Airport? From { get; set; }
    public Airport? To { get; set; }
    public DateOnly? Date { get; set; }
    public TimeOnly? BoardingTime { get; set; }
    public string? Terminal { get; set; }
    public string? Gate { get; set; }
    public TimeSpan? Duration { get; set; }
    public FlightClass FlightClass { get; set; }
    public string? Seat { get; set; }
}
