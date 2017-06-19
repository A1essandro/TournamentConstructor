using System;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{
    internal class Match : Duel
    {
        public Match(Tuple<IGameUnit, IGameUnit> players)
            : base(players)
        {
        }

        public bool? IsDraw { get; private set; } = null;
        public Tuple<int, int> Score { get; private set; }
    }
}