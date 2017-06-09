using System;
using System.Collections.Generic;

namespace TournamentConstructor
{
    class CompositeDuel<TDuel> : Duel
        where TDuel : Duel
    {

        public IList<TDuel> Duels { get; private set; } 

        public CompositeDuel(Tuple<IGameUnit, IGameUnit> players) 
            : base(players)
        {
        }

        public void AddDuel(TDuel duel)
        {
            var selfPlayers = new HashSet<IGameUnit>{ Players.Item1, Players.Item2 };
            var duelPlayers = new HashSet<IGameUnit>{ duel.Players.Item1, duel.Players.Item2 };

            duelPlayers.SymmetricExceptWith(selfPlayers);

            if (duelPlayers.Count != 0)
            {
                throw new ArgumentException();
            }

            Duels.Add(duel);
        }

    }
}
