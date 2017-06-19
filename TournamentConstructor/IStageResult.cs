using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface IStageResult
    {
        IGameUnit[] GameUnits { get; }
    }
}