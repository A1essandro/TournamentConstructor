using System;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public abstract class Stage : IStage
    {

        protected IStageRule Rule;

        public IStage NextStage { get; private set; }

        public ITour[] Tours { get; private set; }

        public IGameUnitWithStatus[] GameUnits { get; private set; }

        public IStageResult Result { get; protected set; }

        protected Stage(IStageRule rule)
        {
            Rule = rule;
            Tours = TourFiller.Fill(Rule.GetSchedule(), GameUnits);
        }

        public void SetUnits(IGameUnitWithStatus[] units)
        {
            GameUnits = units;
        }

        public void SetNextStage(IStage next)
        {
            NextStage = next;
        }

        public abstract bool IsComplete();

        public abstract void ToNextStage();

        public abstract void ToNextTour();

        private class TourFiller
        {

            internal static ITour[] Fill(Tuple<int, int>[][] blank, IGameUnitWithStatus[] GameUnits)
            {
                var result = new Tour[blank.Length];

                var tourIndex = 0;
                foreach (var tour in blank)
                {
                    result[tourIndex++] = new Tour(tour.Select(
                        t => new Duel(GameUnits[t.Item1].GameUnit, GameUnits[t.Item2].GameUnit))
                        .ToArray());
                }

                return result;
            }

        }

    }
}
