using System.Collections.Generic;
using System.Diagnostics;

namespace TournamentConstructor.GameUnit
{

    public interface IGameUnit
    {
        string Name { get; }

        IDictionary<ITournament, IList<IStageStatus>> Status { get; }

    }
}