using TournamentConstructor.Game;

namespace TournamentConstructor.Structure
{
    public interface ITour<TMeetFact>
    {
        IMeet<TMeetFact>[] Games { get; }

        IMeet<TMeetFact> this[int index] { get; }
    }
}