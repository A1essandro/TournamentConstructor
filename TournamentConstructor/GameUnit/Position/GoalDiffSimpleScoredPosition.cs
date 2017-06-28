using System;
using TournamentConstructor.Game;

namespace TournamentConstructor.GameUnit.Position
{
    public class GoalDiffSimpleScoredPosition : SimpleScoredPosition<Match>, IComparable<GoalDiffSimpleScoredPosition>
    {
        private BaseGameUnit baseGameUnit;

        public GoalDiffSimpleScoredPosition(IGameUnit gameUnit, int winScores, int draftScores, int loseScores = 0)
            : base(gameUnit, winScores, draftScores, loseScores)
        {
        }

        public override void AddResult(Match meetResult)
        {
            base.AddResult(meetResult);

            AddGoals(meetResult.GetScores(GameUnit) - meetResult.GetRivalScores(GameUnit));
        }

        public int GoalDiff { get; private set; }

        public void AddGoals(int goals)
        {
            GoalDiff += goals;
        }

        public int CompareTo(GoalDiffSimpleScoredPosition other)
        {
            var parentCompare = base.CompareTo(other);
            if(parentCompare != 0)
            {
                return parentCompare;
            }

            return GoalDiff.CompareTo(other.GoalDiff);
        }
    }
}
