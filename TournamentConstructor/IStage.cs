using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.Structure;
using TournamentConstructor.Structure.Competition;

namespace TournamentConstructor
{
    public interface IStage<TMeetFact> : ITournament where TMeetFact : IMeetFact
    {

        ITour<TMeetFact>[] Tours { get; }

        ITour<TMeetFact> CurrentTour { get; }

        IEnumerable<ICompetition<TMeetFact>> Competitions { get; }

        void SetNextStage(IStage<TMeetFact> next);

        IStage<TMeetFact> ToNextStage();

        void ToNextTour();

    }
}