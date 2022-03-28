namespace BoardingPassShared.Services;

public interface IBoardingPassService
{
    public Task<BoardingPass> GetBoardingPass(Guid passengerId);
}