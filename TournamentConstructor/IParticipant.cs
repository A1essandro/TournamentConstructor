using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface IParticipant
    {

        ICompetition Competition { get; }

        IGameUnit GameUnit { get; }

    }
}