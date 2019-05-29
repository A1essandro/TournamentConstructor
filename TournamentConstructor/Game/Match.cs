using System;
using System.Collections.Generic;
using TournamentConstructor.GameUnit;
using TournamentConstructor.Rule;

namespace TournamentConstructor.Game
{
    public class Match : IMatch
    {

        public Match(IGameUnit a, IGameUnit b)
            : this(new Tuple<IGameUnit, IGameUnit>(a, b))
        {
        }

        public Match(Tuple<IGameUnit, IGameUnit> units)
        {
            Teams = units;
        }

        public bool HasResult => !(Result is null);

        public IResult Result { get; set; }

        public Tuple<IGameUnit, IGameUnit> Teams { get; }

    }
}