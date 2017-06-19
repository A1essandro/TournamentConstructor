using System.Collections.Generic;

namespace TournamentConstructor.GameUnit
{
    public interface IGameUnit
    {
        string Name { get; }

        IDictionary<IStage, IList<IStageStatus>> Status { get; }

        void AddStatus(IStage stage, IStageStatus status);
    }
}