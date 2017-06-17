using System;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public class Stage : IStage
    {

        protected IStageRule Rule;

        public IStage NextStage { get; private set; }

        public ITour[] Tours { get; private set; }

        public IGameUnitWithStatus[] GameUnits { get; private set; }

        public IStageResult Result { get; protected set; }

        protected Stage(IStageRule rule)
        {
            Rule = rule;
        }

        public void SetUnits(IGameUnitWithStatus[] units)
        {
            GameUnits = units;
            Tours = TourFiller.Fill(Rule.GetSchedule(), GameUnits);
        }

        public void SetNextStage(IStage next)
        {
            NextStage = next;
        }

        public bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public void ToNextStage()
        {
            throw new NotImplementedException();
        }

        public void ToNextTour()
        {
            throw new NotImplementedException();
        }

        private class TourFiller
        {

            internal static ITour[] Fill(Tuple<int, int>[][] blank, IGameUnitWithStatus[] GameUnits)
            {
                var result = new Tour[blank.Length];

                var tourIndex = 0;
                foreach (var tour in blank)
                {
                    result[tourIndex++] = new Tour(tour.Select(
                        t => new Duel(GameUnits[t.Item1], GameUnits[t.Item2]))
                        .ToArray());
                }

                return result;
            }

        }

    }
}
