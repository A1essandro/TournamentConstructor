using System;
using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public class ScoreGameResult : IGameResult, IScoreGameResult
    {
        public bool IsDraft => Loser == null && Winner == null;

        public IGameUnit Loser { get; protected set; }

        public IGameUnit Winner { get; protected set; }

        public Tuple<KeyValuePair<IGameUnit, int>, KeyValuePair<IGameUnit, int>> Score { get; }

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

        public ScoreGameResult(Duel game, int first, int second)
            : this(new Tuple<KeyValuePair<IGameUnit, int>, KeyValuePair<IGameUnit, int>>
                  (new KeyValuePair<IGameUnit, int>(game.Players.Item1, first),
                   new KeyValuePair<IGameUnit, int>(game.Players.Item2, second)))
        {

        }

    }
}
