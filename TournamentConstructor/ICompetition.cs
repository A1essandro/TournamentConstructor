using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnits;

namespace TournamentConstructor
{
    public interface ICompetition
    {

        IEnumerable<IGame> Matches { get; }

        bool IsCompleted { get; }

    }
}