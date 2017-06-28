using System;
using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit.Position;
using TournamentConstructor.Structure.Competition.Scheduler;

namespace TournamentConstructor.Structure.Competition
{
    public abstract class CompetitionBase<TMeetFact> : ICompetition<TMeetFact> where TMeetFact : IMeetFact
    {

        public ITour<TMeetFact>[] Tours { get; }

        public IEnumerable<Position<TMeetFact>> Units => _units.OrderBy(x => x);

        private IEnumerable<Position<TMeetFact>> _units;

        protected IScheduler Scheduler;

        protected CompetitionBase(IScheduler scheduler, IEnumerable<Position<TMeetFact>> units)
        {
            if (units.Select(x => x.GameUnit).GroupBy(v => v).Where(g => g.Count() > 1).Select(g => g.Key).Count() > 0)
                throw new ArgumentException("Duplicate of units");
            Scheduler = scheduler;
            Tours = new ITour<TMeetFact>[scheduler.ToursCount];

            _units = new List<Position<TMeetFact>>(units);
        }
    }
}
