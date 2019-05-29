using System;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{

    public interface IMatch
    {

        bool HasResult { get; }

        IResult Result { get; }

        Tuple<IGameUnit, IGameUnit> Teams { get; }

    }

}