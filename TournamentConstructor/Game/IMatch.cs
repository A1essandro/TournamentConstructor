using System;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Game
{

    public interface IMatch
    {

        bool HasResult { get; }

        IGameResult Result { get; }

        Tuple<IGameUnit, IGameUnit> Teams { get; }

    }

}