using System.Collections.Generic;

namespace TournamentConstructor.GameUnit
{
    public interface IGameUnit
    {
        string Name { get; }

        IDictionary<ITournament, IList<IStageStatus>> Status { get; }

        void AddStatus(ITournament stage, IStageStatus status);
    }
}