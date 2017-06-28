using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit.Position;

namespace TournamentConstructor.Structure.Competition
{
    public interface ICompetition<TMeetFact> where TMeetFact : IMeetFact
    {

        ITour<TMeetFact>[] Tours { get; }

        IEnumerable<Position<TMeetFact>> Units { get; }

    }

}