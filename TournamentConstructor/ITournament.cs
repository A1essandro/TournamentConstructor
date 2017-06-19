using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface ITournament
    {
        IGameUnit[] GameUnits { get; }

        bool IsComplete();

        void SetUnits(IGameUnit[] units);
    }
}