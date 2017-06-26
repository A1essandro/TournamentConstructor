using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure.Competition
{
    public class GoalDiffSimpleScoredGameUnitStatus : SimpleScoredGameUnitStatus<Match>
    {
        public GoalDiffSimpleScoredGameUnitStatus(IGameUnit gameUnit, int winScores, int draftScores, int loseScores = 0)
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

    }
}
