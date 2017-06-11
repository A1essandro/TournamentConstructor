using System;
using System.Collections.Generic;

namespace TournamentConstructor
{
    public class ScoreGameResult : IGameResult
    {
        public bool IsDraft => Loser == null && Winner == null;

        public IGameUnit Loser { get; protected set; }

        public IGameUnit Winner { get; protected set; }

        public Tuple<KeyValuePair<IGameUnit, int>, KeyValuePair<IGameUnit, int>> Score;

        public ScoreGameResult(Tuple<KeyValuePair<IGameUnit, int>, KeyValuePair<IGameUnit, int>> result)
        {
            Score = result;
            if (result.Item1.Value == result.Item2.Value)
                return;

            if (result.Item1.Value > result.Item2.Value)
            {
                Winner = result.Item1.Key;
                Loser = result.Item2.Key;
            }
            else
            {
                Winner = result.Item2.Key;
                Loser = result.Item1.Key;
            }
        }

    }
}
