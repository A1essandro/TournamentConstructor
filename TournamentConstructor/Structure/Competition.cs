using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure
{
    public abstract class Competition<TMeetFact> : ICompetition<TMeetFact>
    {

        public ITour<TMeetFact>[] Tours { get; }

        public SortedSet<GameUnitCompetitionStatus> Units { get; private set; }

        protected IScheduler _scheduler;

        protected Competition(IScheduler scheduler, IEnumerable<IGameUnit> units, IComparer<GameUnitCompetitionStatus> comparer)
        {
            _scheduler = scheduler;
            Tours = new ITour<TMeetFact>[scheduler.ToursCount];

            FillUnits(units, comparer);
        }

        private void FillUnits(IEnumerable<IGameUnit> units, IComparer<GameUnitCompetitionStatus> comparer)
        {
            Units = new SortedSet<GameUnitCompetitionStatus>(comparer);
            foreach (var unit in units)
            {
                Units.Add(new GameUnitCompetitionStatus(unit));
            }
        }
    }
}
