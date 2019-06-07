using TournamentConstructor.GameUnits;

namespace TournamentConstructor
{
    public interface ITournament
    {
        ITeam[] GameUnits { get; }

        bool Completed { get; }

        void SetUnits(ITeam[] units);

        void Start();

        void Finish();
    }
}