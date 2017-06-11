using System;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Structure;

namespace TournamentConstructor.Game
{
    public class Duel
    {

        public bool IsComplete { get; protected set; }
        public Tuple<IGameUnit, IGameUnit> Players { get; private set; }
        public IGameResult Result { get; private set; }
        public ITour Tour { get; private set; }

        public Duel(Tuple<IGameUnit, IGameUnit> players)
        {
            Players = players;
        }

        public void SetResult(IGameResult result)
        {
            IsComplete = true;
            Result = result;
        }

    }
}
