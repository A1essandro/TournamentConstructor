using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public interface IResult
    {

        bool IsDraw { get; }

        IGameUnit Winner { get; }

        IGameUnit Loser { get; }

    }
}