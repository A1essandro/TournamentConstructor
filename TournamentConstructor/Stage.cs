using System;
using System.Collections.Generic;
using System.Linq;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure;
using TournamentConstructor.Structure.Competition;

namespace TournamentConstructor
{
    public class Stage<TMeetType> : IStage<TMeetType> where TMeetType : IMeetFact
    {
        public Stage()
        {
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
        }

        public void SetNextStage(IStage<TMeetType> next)
        {
            NextStage = next;
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

            _resultCalculated = true;
        }

        public IStage<TMeetType> ToNextStage()
        {
            return NextStage;
        }

        #region Fields

        private int _currentTourIndex;
        private bool _started;
        private bool _resultCalculated;

        #endregion

        #region Properties

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

        public bool Completed => _started && Tours.SelectMany(t => t.Games).All(g => g.IsComplete);

        public IStage<TMeetType> NextStage { get; private set; }

        public ITour<TMeetType>[] Tours => Competitions.SelectMany(c => c.Tours).ToArray();

        public IGameUnit[] GameUnits { get; private set; }

        public IEnumerable<ICompetition<TMeetType>> Competitions { get; private set; }

        #endregion
    }
}