using System.Linq;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface IGameUnitWithStatus
    {

        IGameUnit GameUnit { get; }

        ILookup<IStage, IStageStatus> Status { get; }

    }
}