using System;

namespace TournamentConstructor
{
    class Match : Duel
    {

        public bool? IsDraw { get; private set; } = null;
        public Tuple<int, int> Score { get; private set; }

        public Match(Tuple<IGameUnit, IGameUnit> players)
            : base(players)
        {

        }

        public void SetScore(Tuple<int, int> score)
        {
            Score = score;
            if (score.Item1 > score.Item2)
            {
                SetWinner(Players.Item1);
                IsDraw = false;
            }
            else if (score.Item1 < score.Item2)
            {
                SetWinner(Players.Item2);
                IsDraw = false;
            }
            else
            {
                IsDraw = true;
                IsComplete = true;
            }
        }

    }
}
