namespace BoardingPassShared.Models;

public class BoardingPass
{
    public static Guid TestId = Guid.Parse("D283617A-7621-4A6E-B44C-93A3D8E790D0");

    public Flight? Flight { get; set; }
    public Passenger? Passenger { get; set; }
}