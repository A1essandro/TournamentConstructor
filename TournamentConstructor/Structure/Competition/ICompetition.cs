using System.Collections.Generic;
using TournamentConstructor.Game;

namespace TournamentConstructor.Structure.Competition
{
    public interface ICompetition<TMeetFact> where TMeetFact : IMeetFact
    {

        ITour<TMeetFact>[] Tours { get; }

        SortedSet<GameUnitStatus<TMeetFact>> Units { get; }

    }

}