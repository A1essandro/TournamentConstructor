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

    }
}
