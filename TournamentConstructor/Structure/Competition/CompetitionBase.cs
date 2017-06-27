using System.Collections.Generic;
using TournamentConstructor.Game;

namespace TournamentConstructor.Structure.Competition
{
    public abstract class CompetitionBase<TMeetFact> : ICompetition<TMeetFact> where TMeetFact : IMeetFact
    {

        public ITour<TMeetFact>[] Tours { get; }

        public SortedSet<GameUnitStatus<TMeetFact>> Units { get; private set; }

        protected IScheduler Scheduler;

        protected CompetitionBase(IScheduler scheduler, IEnumerable<GameUnitStatus<TMeetFact>> units)
        {
            Scheduler = scheduler;
            Tours = new ITour<TMeetFact>[scheduler.ToursCount];

            Units = new SortedSet<GameUnitStatus<TMeetFact>>(units);
        }
    }
}
