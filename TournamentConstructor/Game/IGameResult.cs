using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public interface IGameResult
    {

        bool IsDraft { get; }

        IGameUnit Winner { get; }

        IGameUnit Loser { get; }

    }
}
