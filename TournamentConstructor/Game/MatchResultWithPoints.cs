using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public class MatchResultWithPoints : IResult
    {
        public bool IsDraw => throw new System.NotImplementedException();

        public IGameUnit Winner => throw new System.NotImplementedException();

        public IGameUnit Loser => throw new System.NotImplementedException();
    }
}