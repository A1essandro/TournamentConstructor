using System.Collections.Generic;
using TournamentConstructor.Game;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface ICompetition
    {

        IEnumerable<IMatch> Matches { get; }

        bool IsCompleted { get; }

    }
}