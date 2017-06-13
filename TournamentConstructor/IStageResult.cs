using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface IStageResult
    {

        IGameUnitWithStatus[] GameUnits { get; }

    }
}