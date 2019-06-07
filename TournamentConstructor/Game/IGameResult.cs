using TournamentConstructor.GameUnits;

namespace TournamentConstructor.Game
{
    public interface IGameResult : IPointsContainer
    {

        bool IsDraw { get; }

        ITeam Winner { get; }

        ITeam Loser { get; }

    }
}