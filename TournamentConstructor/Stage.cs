using System;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public class Stage : IStage
    {

        #region Fields

        private int _currentTourIndex = 0;
        private bool _started = false;

        #endregion

        #region Properties

        protected IStageRule Rule;

        public ITour CurrentTour { get
            {
                if(_started)
                {
                    return Tours[_currentTourIndex];
                }
                throw new InvalidOperationException("Stage not started!");
            }
        }

        public IStage NextStage { get; private set; }

        public ITour[] Tours { get; private set; }

        public IGameUnitWithStatus[] GameUnits { get; private set; }

        public IStageResult Result { get; protected set; }

        #endregion

        public Stage(IStageRule rule)
        {
            Rule = rule;
        }

        public void Start()
        {
            if (GameUnits.Length == 0)
                throw new InvalidOperationException("Stage cannot be started!");
            _started = true;
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
            if (Tours[_currentTourIndex].Games.Any(m => !m.IsComplete))
                throw new InvalidOperationException();
            _currentTourIndex++;
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
