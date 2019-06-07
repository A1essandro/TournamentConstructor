using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public interface IGameResult : IPointsContainer
    {

        bool IsDraw { get; }

        IGameUnit Winner { get; }

        IGameUnit Loser { get; }

    }
}