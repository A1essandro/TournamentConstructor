using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure.Competition
{
    public class SimpleScoredGameUnitStatus<TMeetFact> : GameUnitStatus<TMeetFact> where TMeetFact : IMeetFact
    {
        private readonly int _winScores;
        private readonly int _draftScores;
        private readonly int _loseScores;

        public SimpleScoredGameUnitStatus(IGameUnit gameUnit, int winScores, int draftScores, int loseScores = 0)
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

        public override void Calculate(TMeetFact meetResult)
        {
            if (meetResult.IsDraft)
            {
                AddDraft();
                AddScores(_draftScores);
            }
            else if (meetResult.Winner == GameUnit)
            {
                AddWin();
                AddScores(_winScores);
            }
            else
            {
                AddLose();
                AddScores(_loseScores);
            }
        }
    }
}
