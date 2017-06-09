using System;

namespace TournamentConstructor
{
    class Duel
    {

        public bool IsComplete { get; protected set; }
        public Tuple<IGameUnit, IGameUnit> Players { get; private set; }
        public IGameUnit Winner { get; private set; }
        public IGameUnit Loser { get; private set; }

        public Duel(Tuple<IGameUnit, IGameUnit> players)
        {
            Players = players;
        }

        public void SetWinner(IGameUnit winner)
        {
            IsComplete = true;
            Winner = winner;
            Loser = Players.Item1 == winner 
                ? Players.Item1 
                : Players.Item2;
        }

    }
}
