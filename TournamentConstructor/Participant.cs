using System.Diagnostics;
using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{

    [DebuggerDisplay("{GameUnit.Name}")]
    public class Participant : IParticipant
    {

        public Participant(ICompetition competition, IGameUnit gameUnit)
        {
            Competition = competition;
            GameUnit = gameUnit;
        }

        public ICompetition Competition { get; }

        public IGameUnit GameUnit { get; }

    }
}