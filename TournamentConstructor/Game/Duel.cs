using System;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure;

namespace TournamentConstructor.Game
{
    public class Duel
    {
        public Duel(Tuple<IGameUnit, IGameUnit> players)
        {
            Players = players;
        }

        public Duel(IGameUnit gameUnit1, IGameUnit gameUnit2)
            : this(new Tuple<IGameUnit, IGameUnit>(gameUnit1, gameUnit2))
        {
        }

        public bool IsComplete { get; protected set; }
        public Tuple<IGameUnit, IGameUnit> Players { get; private set; }
        public IGameResult Result { get; private set; }
        public ITour Tour { get; private set; }

        public void SetResult(IGameResult result)
        {
            IsComplete = true;
            Result = result;
        }
    }
}