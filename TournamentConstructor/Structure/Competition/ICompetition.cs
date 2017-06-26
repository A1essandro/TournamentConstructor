using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure.Competition
{
    public interface ICompetition<TMeetFact>
    {

        ITour<TMeetFact>[] Tours { get; }

        SortedSet<GameUnitStatus<TMeetFact>> Units { get; }

    }

}