using TournamentConstructor.GameUnit;

namespace TournamentConstructor
{
    public interface ITournament
    {

        IGameUnitWithStatus[] GameUnits { get; }

        bool IsComplete();

        void SetUnits(IGameUnitWithStatus[] units);

    }
}
