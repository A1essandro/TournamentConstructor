using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface IGameUnitWithStatus : IGameUnit
    {

        IDictionary<IStage, IList<IStageStatus>> Status { get; }

        void AddStatus(IStage stage, IStageStatus status);

    }
}