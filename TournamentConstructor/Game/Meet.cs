using System;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    public class Meet<TResult> : IMeet<TResult>
    {
        public Meet(Tuple<IGameUnit, IGameUnit> players)
        {
            Players = players;
        }

        public Meet(IGameUnit gameUnit1, IGameUnit gameUnit2)
            : this(new Tuple<IGameUnit, IGameUnit>(gameUnit1, gameUnit2))
        {
        }

        public bool IsComplete => Result != null;
        public Tuple<IGameUnit, IGameUnit> Players { get; }
        public TResult Result { get; private set; }

        public void SetResult(TResult result)
        {
            Result = result;
        }
    }
}