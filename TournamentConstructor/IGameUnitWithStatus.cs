using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface IGameUnitWithStatus
    {

        IGameUnit GameUnit { get; }

        IStageStatus Status { get; }

    }
}