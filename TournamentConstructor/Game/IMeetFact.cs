using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public interface IMeetFact
    {
        bool IsDraft { get; }

        IGameUnit Winner { get; }

        IGameUnit Loser { get; }
    }
}