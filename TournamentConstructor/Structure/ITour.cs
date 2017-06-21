using TournamentConstructor.Game;

namespace TournamentConstructor.Structure
{
    public interface ITour<TMeetFact> where TMeetFact : IMeetFact
    {
        IMeet<TMeetFact>[] Games { get; }

        IMeet<TMeetFact> this[int index] { get; }
    }
}