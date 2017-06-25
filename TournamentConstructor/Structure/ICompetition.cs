using System.Collections.Generic;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor.Structure
{
    public interface ICompetition<TMeetFact>
    {

        ITour<TMeetFact>[] Tours { get; }

        SortedSet<GameUnitCompetitionStatus> Units { get; }

    }

    public class GameUnitCompetitionStatus
    {

        public GameUnitCompetitionStatus(IGameUnit gameUnit)
        {
            GameUnit = gameUnit;
        }

        public readonly IGameUnit GameUnit;

        public uint Wins { get; private set; }

        public uint Loses { get; private set; }

        public uint Drafts { get; private set; }

    }

}