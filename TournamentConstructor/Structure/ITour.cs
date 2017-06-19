using TournamentConstructor.Game;

namespace TournamentConstructor.Structure
{
    public interface ITour
    {
        Duel[] Games { get; }

        Duel this[int index] { get; }
    }
}