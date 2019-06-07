using System;
using TournamentConstructor.GameUnits;

namespace TournamentConstructor.Game
{

    public interface IGame
    {

        bool HasResult { get; }

        IGameResult Result { get; }

        Tuple<ITeam, ITeam> Teams { get; }

    }

}