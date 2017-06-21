using System;
using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure;

namespace TournamentConstructor
{
    public class Stage<TMeetType> : IStage<TMeetType>
    {
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

        public void SetUnits(IGameUnit[] units)
        {
            GameUnits = units;
            Tours = TourFiller.Fill(Rule.GetSchedule(), GameUnits);
        }

        public void SetNextStage(IStage<TMeetType> next)
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

        public void Finish()
        {
            if (Tours.Any(t => t.Games.Any(g => !g.IsComplete)))
                throw new InvalidOperationException("Stage cannot be finished! It has incomplete games!");
            if (_resultCalculated)
                throw new InvalidOperationException("Stage has been finished!");

            Rule.SetStatuses(this);
            Result = new StageResult(GameUnits);
            _resultCalculated = true;
        }

        private static class TourFiller
        {
            internal static ITour<TMeetType>[] Fill(Tuple<int, int>[][] blank, IReadOnlyList<IGameUnit> gameUnits)
            {
                var result = new Tour<TMeetType>[blank.Length];

                var tourIndex = 0;
                foreach (var tour in blank)
                {
                    //TODO: ALARM!!!
                    result[tourIndex++] = new Tour<TMeetType>(tour.Select(
                        t => new Meet<TMeetType>(gameUnits[t.Item1], gameUnits[t.Item2]))
                        .ToArray());
                }

                return result;
            }
        }

        #region Fields

        private int _currentTourIndex;
        private bool _started;
        private bool _resultCalculated;

        #endregion

        #region Properties

        protected IStageRule Rule;

        public ITour<TMeetType> CurrentTour
        {
            get
            {
                if (_started)
                {
                    return Tours[_currentTourIndex];
                }
                throw new InvalidOperationException("Stage not started!");
            }
        }

        public IStage<TMeetType> NextStage { get; private set; }

        public IStageResult Result { get; private set; }

        public ITour<TMeetType>[] Tours { get; private set; }

        public IGameUnit[] GameUnits { get; private set; }

        #endregion
    }
}