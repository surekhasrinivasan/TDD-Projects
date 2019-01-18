namespace Mastermind.Service
{
    public class GameStatus : IGameStatus
    {
        public bool GameIsWon;
        public int CorrectNumbers;

        public int CorrectPositions;
    }
}