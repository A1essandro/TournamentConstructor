using System.Collections.Generic;
using TournamentConstructor.Structure;

namespace TournamentConstructor.GameUnit
{
    public interface IGameUnit
    {
        string Name { get; }

        IDictionary<ITournament, IList<IStageStatus>> Status { get; }

        void AddStatus(ITournament stage, IStageStatus status);

    }
}