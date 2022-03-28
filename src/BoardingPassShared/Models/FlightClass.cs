namespace BoardingPassShared.Models;

public enum FlightClass
{
    Economy,
    EconomyPlus,
    EconomyWithSomeLegSpace,
    VeryExpensiveCloseToFrontdoor,
}

public static class FlightClassHelper
{
    public static string? ToDisplayName(FlightClass? flightClass)
    {
        return flightClass switch
        {
            FlightClass.Economy => flightClass.ToString(),
            FlightClass.EconomyPlus => "Economy Plus",
            FlightClass.EconomyWithSomeLegSpace => "Economy Luxe Leg",
            FlightClass.VeryExpensiveCloseToFrontdoor => "First Class",
            _ => flightClass.ToString()
        };
    }
}