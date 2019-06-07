using System.Diagnostics;
using TournamentConstructor.GameUnits;

namespace TournamentConstructor
{

    [DebuggerDisplay("{GameUnit.Name}")]
    public class Participant : IParticipant
    {

        public Participant(ICompetition competition, ITeam gameUnit)
        {
            Competition = competition;
            Team = gameUnit;
        }

        public ICompetition Competition { get; }

        public ITeam Team { get; }

    }
}