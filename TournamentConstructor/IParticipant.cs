using TournamentConstructor.GameUnits;

namespace TournamentConstructor
{

    public interface IParticipant
    {

        ICompetition Competition { get; }

        ITeam Team { get; }

    }
}