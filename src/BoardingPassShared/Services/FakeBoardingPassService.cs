namespace BoardingPassShared.Services;

public class FakeBoardingPassService : IBoardingPassService
{
    public Task<BoardingPass> GetBoardingPass(Guid passengerId)
    {
        var res = new BoardingPass
        {
            Flight = new Flight
            {
                Code = "XJ 607",
                From = new Airport
                {
                    AirportCode = "NRT",
                    City = "Tokyo"
                },
                To = new Airport
                {
                    AirportCode = "DMK",
                    City = "Bangkok"
                },
                Date = new DateOnly(2022, 11, 6),
                Duration = TimeSpan.FromHours(6.01),
                BoardingTime = new TimeOnly(17, 25),
                Seat = "29G",
                Terminal = "1",
                Gate = "39"
            },
            Passenger = new Passenger
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last()
            }
        };
        return Task.FromResult(res);
    }
}