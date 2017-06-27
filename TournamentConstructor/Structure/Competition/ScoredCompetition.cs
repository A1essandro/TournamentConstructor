using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit.Position;
using TournamentConstructor.Structure.Competition.Scheduler;

namespace TournamentConstructor.Structure.Competition
{
    public class ScoredCompetition : CompetitionBase<Match>
    {

        public ScoredCompetition(IScheduler scheduler, Position<Match>[] units) 
            : base(scheduler, units)
        {
            var tourIndex = 0;
            foreach (var pTour in Scheduler.GetTours())
            {
                var games = new List<Meet<Match>>();
                foreach (var pGame in pTour)
                {
                    games.Add(new Meet<Match>(units[pGame.Item1].GameUnit, units[pGame.Item2].GameUnit));
                }
                Tours[tourIndex++] = new Tour<Match>(games.ToArray());
            }
        }

    }
}
