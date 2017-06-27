﻿using System;
using TournamentConstructor.Game;

namespace TournamentConstructor.GameUnit.Position
{
    public class SimpleScoredPosition<TMeetFact> : Position<TMeetFact>, IComparable<SimpleScoredPosition<TMeetFact>>
        where TMeetFact : IMeetFact
    {
        private readonly int _winScores;
        private readonly int _draftScores;
        private readonly int _loseScores;

        public SimpleScoredPosition(IGameUnit gameUnit, int winScores, int draftScores, int loseScores = 0)
            : base(gameUnit)
        {
            _winScores = winScores;
            _draftScores = draftScores;
            _loseScores = loseScores;
        }

        public int Scores { get; set; }

        public void AddScores(int scores)
        {
            Scores += scores;
        }

        public override void AddResult(TMeetFact meetResult)
        {
            base.AddResult(meetResult);
            if (meetResult.IsDraft)
            {
                AddScores(_draftScores);
            }
            else if (meetResult.Winner == GameUnit)
            {
                AddScores(_winScores);
            }
            else
            {
                AddScores(_loseScores);
            }
        }

        public int CompareTo(SimpleScoredPosition<TMeetFact> other)
        {
            return Scores.CompareTo(other.Scores);
        }
    }
}