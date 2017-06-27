using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit.Position;
using TournamentConstructor.Structure.Competition.Scheduler;

namespace TournamentConstructor.Structure.Competition
{
    public abstract class CompetitionBase<TMeetFact> : ICompetition<TMeetFact> where TMeetFact : IMeetFact
    {

        public ITour<TMeetFact>[] Tours { get; }

        public SortedSet<Position<TMeetFact>> Units { get; private set; }

        protected IScheduler Scheduler;

        protected CompetitionBase(IScheduler scheduler, IEnumerable<Position<TMeetFact>> units)
        {
            Scheduler = scheduler;
            Tours = new ITour<TMeetFact>[scheduler.ToursCount];

            Units = new SortedSet<Position<TMeetFact>>(units);
        }
    }
}
