using System;
using TournamentConstructor.GameUnits;

namespace TournamentConstructor.Game
{

    [Obsolete]
    public interface IMeetFact
    {
        bool IsDraft { get; }

        ITeam Winner { get; }

        ITeam Loser { get; }
    }
}