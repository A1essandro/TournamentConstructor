using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure.Competition
{
    public abstract class CompetitionBase<TMeetFact> : ICompetition<TMeetFact>
    {

        public ITour<TMeetFact>[] Tours { get; }

        public SortedSet<GameUnitStatus<TMeetFact>> Units { get; private set; }

        protected IScheduler Scheduler;

        protected CompetitionBase(IScheduler scheduler, IEnumerable<GameUnitStatus<TMeetFact>> units, IComparer<GameUnitStatus<TMeetFact>> comparer)
        {
            Scheduler = scheduler;
            Tours = new ITour<TMeetFact>[scheduler.ToursCount];

            Units = new SortedSet<GameUnitStatus<TMeetFact>>(units, comparer);
        }
    }
}
